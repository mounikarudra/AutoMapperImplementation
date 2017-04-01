namespace LoginAndRegistrationDAL
{
    public interface IAuthenticate
    {
        bool DALRegister(string username, string password);
        bool DALLogin(string username, string password);
        bool DALForgotPassword(string username, string password);
    }
}
