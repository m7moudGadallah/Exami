--DATABASE Creation --
USE master;
DROP DATABASE IF EXISTS Exami;
GO

CREATE DATABASE Exami;
GO

USE Exami;
GO

CREATE TABLE [User] (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(25),
    LastName VARCHAR(25),
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Teacher', 'Student')),
    Email VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(30) NOT NULL
);

CREATE TABLE Subject (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    TeacherId INT FOREIGN KEY REFERENCES [User](Id) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Exam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL,
    ExamType NVARCHAR(20) NOT NULL CHECK (ExamType IN ('Practice', 'Final')),
    Instructions NVARCHAR(1000)
);

CREATE TABLE Question (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Body NVARCHAR(500) NOT NULL,
    Marks FLOAT NOT NULL,
    QuestionType VARCHAR(20) NOT NULL CHECK (QuestionType IN ('TrueOrFalse', 'ChooseOne', 'ChooseAll')),
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Answer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionId INT FOREIGN KEY REFERENCES Question(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    AnswerText NVARCHAR(50) NOT NULL,
    IsCorrect BIT NOT NULL
);

CREATE TABLE ExamQuestion (
    ExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (ExamId, QuestionId),
    FOREIGN KEY (ExamId) REFERENCES Exam(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (QuestionId) REFERENCES Question(Id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE StudentExam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ExamId INT NOT NULL FOREIGN KEY REFERENCES Exam(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    StudentId INT NOT NULL FOREIGN KEY REFERENCES [User](Id) ON DELETE CASCADE ON UPDATE CASCADE,
    SubmissionTime DATETIME,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NOT NULL
);

CREATE TABLE MarkedQuestion (
    StudentExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (StudentExamId, QuestionId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (QuestionId) REFERENCES Question(Id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE StudentAnswer (
    StudentExamId INT NOT NULL,
    AnswerId INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (StudentExamId, AnswerId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (AnswerId) REFERENCES Answer(Id) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

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
    [QuestionFullView] q ON eq.QuestionId = q.Id;
