namespace Harmonics.Validation
{
    public static class ErrorMessages
    {
        public const string AlreadyExists = "User with this login is already exists";
        public const string LoginIsEmpty = "Please input login";
        public const string PasswordIsEmpty = "Please input password";
        public const string LoginTooLong = "Login maximum length is 20";
        public const string PasswordTooLong = "Password maximum length is 20";
        public const string LoginAndPasswordStructure = "The username and password can only consist of letters and numbers";
        public const string WrongLoginOrPassword = "Wrong login or password";
    }
}