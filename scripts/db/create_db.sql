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
    TeacherId INT FOREIGN KEY REFERENCES [User](Id)
);

CREATE TABLE Exam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id),
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
    SubjectId INT FOREIGN KEY REFERENCES Subject(Id)
);

CREATE TABLE Answer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionId INT FOREIGN KEY REFERENCES Question(Id),
    AnswerText NVARCHAR(50) NOT NULL,
    IsCorrect BIT NOT NULL
);

CREATE TABLE ExamQuestion (
    ExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (ExamId, QuestionId),
    FOREIGN KEY (ExamId) REFERENCES Exam(Id),
    FOREIGN KEY (QuestionId) REFERENCES Question(Id)
);

CREATE TABLE StudentExam (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ExamId INT FOREIGN KEY REFERENCES Exam(Id),
    StudentId INT FOREIGN KEY REFERENCES [User](Id),
    SubmissionTime DATETIME,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME
);

CREATE TABLE MarkedQuestion (
    StudentExamId INT NOT NULL,
    QuestionId INT NOT NULL,
    PRIMARY KEY (StudentExamId, QuestionId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id),
    FOREIGN KEY (QuestionId) REFERENCES Question(Id)
);

CREATE TABLE StudentAnswer (
    StudentExamId INT NOT NULL,
    AnswerId INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (StudentExamId, AnswerId),
    FOREIGN KEY (StudentExamId) REFERENCES StudentExam(Id),
    FOREIGN KEY (AnswerId) REFERENCES Answer(Id)
);
