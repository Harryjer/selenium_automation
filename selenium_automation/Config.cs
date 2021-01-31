

namespace selenium_automation
{
    public static class Config
    {
        public static string BaseUrl = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234";
                public static string RepeatPassword = "asdf1234";
                public static string Email = "example@example.com";

            }
            public static class InValid
            {
                public static class Username
                {
                    public static string FourCharactors = "Asdf";
                    public static string ThirteenCharactors = "AsdfAsdfAsdfG";
                }
                public static class Password
                {
                    public static string FourCharactors = "asdf";
                    public static string ThirteenCharactors = "AsdfAsdfAsdfG";
                }
                public static class Email
                {

                }
            }
        }
        public static class AlertMessages
        {
            public static string SuccessfullLogin = "Successfulll Login";
            public static string UsernameLengthOutofRange = "Username length is out of range";
            public static string PasswordLengthOutofRange = "Password length is out of range";
        }
    }
}
