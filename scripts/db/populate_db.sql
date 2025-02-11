--------  Dummy Data  -----------

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

-- Insert Subjects
INSERT INTO Subject (Name, TeacherId) VALUES
('Mathematics', 3),
('Physics', 4),
('Chemistry', 5),
('History', 3),
('Computer Science', 4);

-- Insert Exams
INSERT INTO Exam (Name, SubjectId, StartTime, EndTime, ExamType, Instructions) VALUES
('Math Final Exam', 1, '2025-06-01 10:00', '2025-06-01 12:00', 'Final', 'Solve all questions.'),
('Physics Midterm', 2, '2025-06-10 14:00', '2025-06-10 16:00', 'Practice', 'Use only a scientific calculator.'),
('Chemistry Practical', 3, '2025-06-15 09:00', '2025-06-15 11:00', 'Final', 'Lab coats are mandatory.'),
('History Quiz', 4, '2025-06-20 13:00', '2025-06-20 14:00', 'Practice', 'Answer all multiple-choice questions.'),
('CS Programming Test', 5, '2025-06-25 15:00', '2025-06-25 17:00', 'Final', 'Write code using Python or Java.');

-- Insert Questions
INSERT INTO Question (Body, Marks, QuestionType, SubjectId) VALUES
('What is 5 + 7?', 1.0, 'ChooseOne', 1),
('Solve: 2x + 3 = 11', 2.0, 'ChooseOne', 1),
('Who discovered gravity?', 2.0, 'ChooseOne', 2),
('What is the atomic number of Oxygen?', 2.0, 'ChooseOne', 3),
('Which year did WWI start?', 2.0, 'ChooseOne', 4),
('What is the time complexity of binary search?', 2.0, 'ChooseOne', 5),
('True or False: Water boils at 100°C at sea level.', 1.0, 'TrueOrFalse', 3),
('Which of the following are prime numbers? (Choose all that apply)', 3.0, 'ChooseAll', 1);

-- Insert Answers
INSERT INTO Answer (QuestionId, AnswerText, IsCorrect) VALUES
(1, '12', 1),
(1, '11', 0),
(2, 'x = 4', 1),
(2, 'x = 5', 0),
(3, 'Isaac Newton', 1),
(3, 'Albert Einstein', 0),
(4, '8', 0),
(4, '16', 0),
(4, '8', 0),
(4, 'Oxygen', 1),
(5, '1914', 1),
(5, '1945', 0),
(6, 'O(log n)', 1),
(6, 'O(n^2)', 0),
(7, 'True', 1),
(7, 'False', 0),
(8, '2', 1),
(8, '4', 0),
(8, '5', 1),
(8, '7', 1);

-- Insert ExamQuestion relations
INSERT INTO ExamQuestion (ExamId, QuestionId) VALUES
(1, 1), (1, 2),
(2, 3), (2, 4),
(3, 5), (3, 7),
(4, 6), (4, 8);

-- Insert Student Exams
INSERT INTO StudentExam (ExamId, StudentId, SubmissionTime) VALUES
(1, 6, '2025-06-01 12:00'),
(2, 7, '2025-06-10 16:00'),
(3, 8, '2025-06-15 11:00'),
(4, 9, '2025-06-20 14:00'),
(5, 10, '2025-06-25 17:00');

-- Insert Marked Questions
INSERT INTO MarkedQuestion (StudentExamId, QuestionId) VALUES
(1, 1), (1, 2),
(2, 3), (2, 4),
(3, 5), (3, 7),
(4, 6), (4, 8);

-- Insert Student Answers
INSERT INTO StudentAnswer (StudentExamId, AnswerId) VALUES
(1, 1), (1, 2),
(2, 3), (2, 4),
(3, 5), (3, 7),
(4, 6), (4, 8);

