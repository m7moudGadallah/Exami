using Entities;

namespace Presentation
{
    public static class UserSession
    {
        public static User LoggedInUser { get; private set; }

        public static void SetUser(User user)
        {
            LoggedInUser = user;
        }

        public static void ClearSession()
        {
            LoggedInUser = null;
        }
    }

}
