namespace LoginAndRegistrationBL
{
    public interface IFormType
    {
        bool Login(string username, string password);
        bool Registration(string username, string password);
        bool ResetPassword(string username, string password);
    }
}
