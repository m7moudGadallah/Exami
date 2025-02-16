using Entities;

namespace Presentation.Helpers
{
    internal static class ExamSession
    {
        public static int LoggedInUser { get; private set; }
        public static int SelectedExam { get; private set; }

        public static void SetSession(int user, int exam)
        {
            LoggedInUser = user;
            SelectedExam = exam;
        }

        public static void ClearSession()
        {
            LoggedInUser = 0;
            SelectedExam = 0;
        }
    }
}
