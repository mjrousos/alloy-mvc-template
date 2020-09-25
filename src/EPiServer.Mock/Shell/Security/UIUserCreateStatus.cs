namespace EPiServer.Shell.Security
{
    public enum UIUserCreateStatus
    {
        DuplicateEmail,
        DuplicateProviderUserKey,
        DuplicateUserName,
        InvalidAnswer,
        InvalidEmail,
        InvalidPassword,
        InvalidProviderUserKey,
        InvalidQuestion,
        InvalidUserName,
        ProviderError,
        Success,
        UserRejected
    }
}
