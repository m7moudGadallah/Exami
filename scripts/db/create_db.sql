USE master;
DROP DATABASE IF EXISTS Exami;
GO

CREATE DATABASE Exami;
GO

USE Exami;
GO


-- User Table
CREATE TABLE [User] (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(25),
    LastName VARCHAR(25),
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Teacher', 'Student')),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(30) NOT NULL
);
GO

-- Subject Table
CREATE TABLE Subject (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    TeacherId INT FOREIGN KEY REFERENCES [User](Id) ON DELETE SET NULL ON UPDATE CASCADE
);
GO

-- Exam Table
CREATE TABLE Exam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id) ON DELETE CASCADE ON UPDATE CASCADE, -- If a Subject is deleted, delete related Exams
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    ExamType NVARCHAR(20) NOT NULL CHECK (ExamType IN ('Practice', 'Final')),
    Instructions NVARCHAR(1000)
);
GO

-- Question Table
CREATE TABLE Question (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Body NVARCHAR(500) NOT NULL,
    Marks FLOAT NOT NULL,
    QuestionType VARCHAR(20) NOT NULL CHECK (QuestionType IN ('TrueOrFalse', 'ChooseOne', 'ChooseAll')),
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id) ON DELETE CASCADE ON UPDATE CASCADE -- If Subject is deleted, delete related Questions
);
GO

-- Answer Table
CREATE TABLE Answer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionId INT FOREIGN KEY REFERENCES Question(Id) ON DELETE CASCADE ON UPDATE CASCADE, -- If Question is deleted, delete related Answers
	AnswerText NVARCHAR(50) NOT NULL,
    IsCorrect BIT NOT NULL
);
GO

-- ExamQuestion Table
CREATE TABLE ExamQuestion (
    ExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (ExamId, QuestionId),
    FOREIGN KEY (ExamId) REFERENCES Exam(Id) ON DELETE CASCADE ON UPDATE CASCADE, -- If Exam is deleted, remove its questions
    FOREIGN KEY (QuestionId) REFERENCES Question(Id) ON DELETE NO ACTION ON UPDATE NO ACTION -- Prevent cycle with Question
);
GO

-- StudentExam Table
CREATE TABLE StudentExam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ExamId INT NULL FOREIGN KEY REFERENCES Exam(Id) ON DELETE SET NULL,
    StudentId INT NULL FOREIGN KEY REFERENCES [User](Id) ON DELETE SET NULL,
    SubmissionTime DATETIME,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Trigger to Delete Orphaned StudentExam Records
CREATE TRIGGER trg_Cleanup_Orphaned_StudentExam
ON StudentExam
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Delete rows where both ExamId and StudentId are NULL (orphaned)
    DELETE FROM StudentExam WHERE ExamId IS NULL OR StudentId IS NULL;
END;
GO

-- MarkedQuestion Table
CREATE TABLE MarkedQuestion (
    StudentExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (StudentExamId, QuestionId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id) ON DELETE CASCADE, -- If StudentExam is deleted, remove marks
    FOREIGN KEY (QuestionId) REFERENCES Question(Id) ON DELETE CASCADE -- If Question is deleted, remove marks
);
GO

-- StudentAnswer Table
CREATE TABLE StudentAnswer (
    StudentExamId INT NOT NULL,
    AnswerId INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (StudentExamId, AnswerId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id) ON DELETE CASCADE, -- If StudentExam is deleted, remove answers
    FOREIGN KEY (AnswerId) REFERENCES Answer(Id) ON DELETE CASCADE -- If Answer is deleted, remove StudentAnswer
);
GO

-- Views
CREATE VIEW [StudentExamFullView] AS
SELECT
	se.*,
	u.FirstName,
	u.LastName,
	u.Role,
	u.Email,
	u.Password,
	e.Name,
	e.SubjectId,
	e.StartTime,
	e.EndTime,
	e.ExamType,
	e.Instructions
FROM 
    [StudentExam] se
INNER JOIN 
    [User] u ON se.StudentId = u.Id
INNER JOIN 
    [Exam] e ON se.ExamId = e.Id;
GO

CREATE VIEW [QuestionFullView] AS
SELECT
	q.*,
	a.Id AS AnswerId,
	a.AnswerText,
	a.IsCorrect
FROM 
    [Question] q
LEFT JOIN 
    [Answer] a ON q.Id = a.QuestionId;
GO

    CREATE VIEW [ExamFullView] AS
SELECT
	e.Id,
	e.Name,
	e.StartTime,
	e.EndTime,
	e.ExamType,
	e.Instructions,
	e.SubjectId,
	s.Name AS SubjectName,
	s.TeacherId,
	t.FirstName,
	t.LastName,
	t.Role,
	t.Email,
	t.Password
FROM 
	[Exam] e
LEFT JOIN
	[Subject] s ON e.SubjectId = s.Id
LEFT JOIN 
	[User] t ON s.TeacherId = t.Id;
GO

CREATE VIEW [SubjectFullView] AS
SELECT
	s.Id,
	s.Name,
	s.TeacherId,
	t.FirstName,
	t.LastName,
	t.Role,
	t.Email,
	t.Password
FROM
	[Subject] s
LEFT JOIN 
	[User] t ON s.TeacherId = t.Id;
GO

CREATE VIEW [ExamQuestionFullView] AS
SELECT
	eq.*,
	eq.QuestionId AS Id,
	q.Body,
	q.Marks,
	q.QuestionType,
	q.SubjectId,
	q.AnswerId,
	q.AnswerText,
	q.IsCorrect
FROM ExamQuestion eq
LEFT JOIN
	[QuestionFullView]  q on eq.QuestionId = q.Id;
GO

CREATE VIEW StudentExamScores AS
WITH ExamTotalMarks AS (
    -- Get total marks for each exam (include exams with no questions)
    SELECT 
        e.Id AS ExamId, 
        COALESCE(SUM(q.Marks), 0) AS ExamScore  -- Default to 0 if no questions
    FROM Exam e
    LEFT JOIN ExamQuestion eq ON e.Id = eq.ExamId
    LEFT JOIN Question q ON eq.QuestionId = q.Id
    GROUP BY e.Id
), 

StudentCorrectAnswers AS (
    -- Check if student selected ALL correct answers for a question
    SELECT 
        se.Id AS StudentExamId, 
        q.Id AS QuestionId,
        q.Marks,
        CASE 
            WHEN COUNT(CASE WHEN a.IsCorrect = 1 THEN sa.AnswerId END) = 
                 COUNT(CASE WHEN a.IsCorrect = 1 THEN a.Id END) 
            AND COUNT(CASE WHEN a.IsCorrect = 0 THEN sa.AnswerId END) = 0
            THEN q.Marks 
            ELSE 0 
        END AS EarnedMarks
    FROM StudentExam se
    JOIN Exam e ON se.ExamId = e.Id
    LEFT JOIN ExamQuestion eq ON e.Id = eq.ExamId
    LEFT JOIN Question q ON eq.QuestionId = q.Id
    LEFT JOIN Answer a ON q.Id = a.QuestionId
    LEFT JOIN StudentAnswer sa ON sa.StudentExamId = se.Id AND sa.AnswerId = a.Id
    GROUP BY se.Id, q.Id, q.Marks
),

StudentTotalScore AS (
    -- Sum up the marks earned per student exam (ensure all students are included)
    SELECT 
        se.Id AS StudentExamId, 
        COALESCE(SUM(sca.EarnedMarks), 0) AS StudentScore  -- Default to 0 if no answers
    FROM StudentExam se
    LEFT JOIN StudentCorrectAnswers sca ON se.Id = sca.StudentExamId
    GROUP BY se.Id
)

-- Final View (Only Exams that Have at Least One StudentExamId)
SELECT 
    se.Id AS StudentExamId, 
    etm.ExamScore, 
    COALESCE(sts.StudentScore, 0) AS StudentScore  -- Default to 0 if no student score
FROM StudentExam se
JOIN ExamTotalMarks etm ON se.ExamId = etm.ExamId
LEFT JOIN StudentTotalScore sts ON se.Id = sts.StudentExamId;
GO

CREATE VIEW ExamStudentPerformanceView AS
SELECT 
    e.Id AS ExamId,
	se.Id As StudentExamId,
    e.Name AS ExamName,
    CONCAT(u.FirstName, ' ', u.LastName) AS StudentName,
    e.StartTime AS ExamStartTime,
    se.SubmissionTime AS ExamSubmissionTime,
    ses.StudentScore AS StudentScore
FROM StudentExam se
JOIN StudentExamScores ses ON se.Id = ses.StudentExamId
JOIN Exam e ON se.ExamId = e.Id
JOIN [User] u ON se.StudentId = u.Id;
GO

CREATE VIEW ExamStatisticsView AS
SELECT 
    e.Id AS ExamId,
    COALESCE(AVG(ses.StudentScore), 0) AS AverageScore
FROM Exam e
LEFT JOIN StudentExam se ON e.Id = se.ExamId
LEFT JOIN StudentExamScores ses ON se.Id = ses.StudentExamId
GROUP BY e.Id;
GO