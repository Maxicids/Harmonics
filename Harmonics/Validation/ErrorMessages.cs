namespace Harmonics.Validation
{
    public static class ErrorMessages
    {
        #region Login/Registration

        public const string AlreadyExists = "User with this login is already exists";
        public const string LoginIsEmpty = "Please input login";
        public const string PasswordIsEmpty = "Please input password";
        public const string LoginTooLong = "Login maximum length is 20";
        public const string LoginTooShort = "Login minimum length is 4";
        public const string PasswordTooLong = "Password maximum length is 20";
        public const string PasswordTooShort = "Password minimum length is 4";
        public const string LoginAndPasswordStructure = "The username and password can only consist of letters and numbers";
        public const string WrongLoginOrPassword = "Wrong login or password";
        public const string HasBeenBlocked = "This account has been blocked";
        public const string AlreadySignedIn = "This user is already signed in";

        #endregion

        #region Setting

        public const string DescriptionMaxLength = "Descroption max length is 200 symbols";
        public const string TextSizeRange = "Text size range must be from 12 to 16";

        #endregion
        
        #region AddUser

        public const string AlreadyInChat = "This user is already in chat";
        public const string NoSuchUser = "No such user found";

        #endregion
    }
}