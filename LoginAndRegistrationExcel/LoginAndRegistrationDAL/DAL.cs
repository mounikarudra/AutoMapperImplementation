using System;
using System.Configuration;

namespace LoginAndRegistrationDAL
{
    public class DAL : IAuthenticate
    {
        Excel _excelObj = new Excel();

        /// <summary>
        /// Creates a new excel file if it is not created already.
        /// </summary>
        public DAL()
        {
            if (!System.IO.File.Exists(ConfigurationManager.AppSettings["path"]))
            {
                Console.WriteLine("flag " + _excelObj.CreateExcel());
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        /// <summary>
        /// Calls the AddDetails method to add the user details to the excel file.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the details are added,otherwise false.</returns>
        public bool DALRegister(string username, string password)
        {
            return _excelObj.AddDetails(username, password);

        }

        /// <summary>
        /// Calls the FetchDetails method to check the details entered by the user to login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the details are valid,otherwise false.</returns>
        public bool DALLogin(string username, string password)
        {
            return _excelObj.FetchDetails(username, password);
        }

        /// <summary>
        /// calls the ChangePassword method to update the password entered by the user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if the password is updated,otherwise false.</returns>
        public bool DALForgotPassword(string username, string password)
        {
            return _excelObj.ChangePassword(username, password);
        }
    }
}
