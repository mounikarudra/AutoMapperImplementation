using LoginAndRegistrationDAL;

namespace LoginAndRegistrationBL
{
    internal class Authenticate : IFormType
    {
        LoginAndRegistrationDAL.IAuthenticate _DALObj;
        public Authenticate()
        {
            _DALObj = AuthenticateFactory.GetAuthObj();
        }

        /// <summary>
        /// calls the method DALLogin in LoginAndRegistrationDAL to authenticate the user to login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the user is authenticated successfully,otherwise false.</returns>
        public bool Login(string username, string password)
        {
            return _DALObj.DALLogin(username, password);
        }

        /// <summary>
        /// calls the method DALRegister in LoginAndRegistrationDAL to add the details of the user to excel sheet.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the user is added successfully,otherwise false.</returns>
        public bool Registration(string username, string password)
        {
            return _DALObj.DALRegister(username, password);
        }

        /// <summary>
        /// calls the method DALForgotPassword in LoginAndRegistrationDAL to update the password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the password is changed successfully,otherwise false.</returns>
        public bool ResetPassword(string username, string password)
        {
            return _DALObj.DALForgotPassword(username, password);
        }
    }
}
