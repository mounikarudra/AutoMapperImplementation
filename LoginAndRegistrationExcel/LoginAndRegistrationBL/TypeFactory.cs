namespace LoginAndRegistrationBL
{
    public class TypeFactory
    {
        public IFormType getType()
        {
            return new Authenticate();
        }
    }
}
