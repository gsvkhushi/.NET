namespace dependencyproject.services
{
    public class myservice : Imyservice

    {
        public string GetMessage()
        {
            return "Hello from myservice using Dependency Injection ";
        }
    }
}
