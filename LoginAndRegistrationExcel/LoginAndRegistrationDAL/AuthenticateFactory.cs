namespace LoginAndRegistrationDAL
{
    public class AuthenticateFactory
    {
        /// <summary>
        /// used to create an object of DAL class.
        /// </summary>
        /// <returns>DAL object.</returns>
        public static IAuthenticate GetAuthObj()
        {
            return new DAL();
        }
    }
}
