USE Exami;
GO

-- Insert Users (Admins, Teachers, and Students)
INSERT INTO [User] (FirstName, LastName, Role, Email, Password) VALUES
('John', 'Doe', 'Admin', 'john.doe@example.com', 'password123'),
('Jane', 'Williams', 'Admin', 'jane.williams@example.com', 'password123'),
('Alice', 'Smith', 'Teacher', 'alice.smith@example.com', 'password123'),
('Michael', 'Johnson', 'Teacher', 'michael.johnson@example.com', 'password123'),
('Sarah', 'Davis', 'Teacher', 'sarah.davis@example.com', 'password123'),
('Bob', 'Brown', 'Student', 'bob.brown@example.com', 'password123'),
('Emily', 'Miller', 'Student', 'emily.miller@example.com', 'password123'),
('James', 'Wilson', 'Student', 'james.wilson@example.com', 'password123'),
('Sophia', 'Moore', 'Student', 'sophia.moore@example.com', 'password123'),
('Daniel', 'Anderson', 'Student', 'daniel.anderson@example.com', 'password123');
GO

-- Insert Subjects (Linked to Teachers)
INSERT INTO Subject (Name, TeacherId) VALUES
('Mathematics', (SELECT Id FROM [User] WHERE Email = 'alice.smith@example.com')),
('Physics', (SELECT Id FROM [User] WHERE Email = 'michael.johnson@example.com')),
('Chemistry', (SELECT Id FROM [User] WHERE Email = 'sarah.davis@example.com')),
('History', (SELECT Id FROM [User] WHERE Email = 'alice.smith@example.com')),
('Computer Science', (SELECT Id FROM [User] WHERE Email = 'michael.johnson@example.com'));
GO

-- Insert Exams (Linked to Subjects)
INSERT INTO Exam (Name, SubjectId, StartTime, EndTime, ExamType, Instructions) VALUES
('Math Final Exam', (SELECT Id FROM Subject WHERE Name = 'Mathematics'), '2025-06-01 10:00', '2025-06-01 12:00', 'Final', 'Solve all questions.'),
('Physics Midterm', (SELECT Id FROM Subject WHERE Name = 'Physics'), '2025-06-10 14:00', '2025-06-10 16:00', 'Practice', 'Use only a scientific calculator.'),
('Chemistry Practical', (SELECT Id FROM Subject WHERE Name = 'Chemistry'), '2025-06-15 09:00', '2025-06-15 11:00', 'Final', 'Lab coats are mandatory.'),
('History Quiz', (SELECT Id FROM Subject WHERE Name = 'History'), '2025-06-20 13:00', '2025-06-20 14:00', 'Practice', 'Answer all multiple-choice questions.'),
('CS Programming Test', (SELECT Id FROM Subject WHERE Name = 'Computer Science'), '2025-06-25 15:00', '2025-06-25 17:00', 'Final', 'Write code using Python or Java.');
GO

-- Insert Questions (Linked to Subjects)
INSERT INTO Question (Body, Marks, QuestionType, SubjectId) VALUES
('What is 5 + 7?', 1, 'ChooseOne', (SELECT Id FROM Subject WHERE Name = 'Mathematics')),
('Solve: 2x + 3 = 11', 2, 'ChooseOne', (SELECT Id FROM Subject WHERE Name = 'Mathematics')),
('Who discovered gravity?', 2, 'ChooseOne', (SELECT Id FROM Subject WHERE Name = 'Physics')),
('What is the atomic number of Oxygen?', 2, 'ChooseOne', (SELECT Id FROM Subject WHERE Name = 'Chemistry'));
GO

-- Insert Answers (Linked to Questions)
INSERT INTO Answer (QuestionId, AnswerText, IsCorrect) VALUES
((SELECT Id FROM Question WHERE Body = 'What is 5 + 7?'), '12', 1),
((SELECT Id FROM Question WHERE Body = 'What is 5 + 7?'), '10', 0),
((SELECT Id FROM Question WHERE Body = 'Solve: 2x + 3 = 11'), 'x = 4', 1),
((SELECT Id FROM Question WHERE Body = 'Solve: 2x + 3 = 11'), 'x = 5', 0);
GO

-- Insert Exam Questions
INSERT INTO ExamQuestion (ExamId, QuestionId) VALUES
((SELECT Id FROM Exam WHERE Name = 'Math Final Exam'), (SELECT Id FROM Question WHERE Body = 'What is 5 + 7?')),
((SELECT Id FROM Exam WHERE Name = 'Math Final Exam'), (SELECT Id FROM Question WHERE Body = 'Solve: 2x + 3 = 11'));
GO

-- Insert Student Exams
INSERT INTO StudentExam (ExamId, StudentId, SubmissionTime, CreatedAt, UpdatedAt) VALUES
((SELECT Id FROM Exam WHERE Name = 'Math Final Exam'), (SELECT Id FROM [User] WHERE Email = 'bob.brown@example.com'), '2025-06-01 12:00', GETDATE(), GETDATE()),
((SELECT Id FROM Exam WHERE Name = 'Physics Midterm'), (SELECT Id FROM [User] WHERE Email = 'emily.miller@example.com'), '2025-06-10 16:00', GETDATE(), GETDATE());
GO

-- Insert Student Answers
INSERT INTO StudentAnswer (StudentExamId, AnswerId, CreatedAt) VALUES
((SELECT Id FROM StudentExam WHERE StudentId = (SELECT Id FROM [User] WHERE Email = 'bob.brown@example.com')), 
 (SELECT Id FROM Answer WHERE AnswerText = '12' AND QuestionId = (SELECT Id FROM Question WHERE Body = 'What is 5 + 7?')), GETDATE()),

((SELECT Id FROM StudentExam WHERE StudentId = (SELECT Id FROM [User] WHERE Email = 'emily.miller@example.com')), 
 (SELECT Id FROM Answer WHERE AnswerText = 'x = 4' AND QuestionId = (SELECT Id FROM Question WHERE Body = 'Solve: 2x + 3 = 11')), GETDATE());
GO
