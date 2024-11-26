namespace pTodo.Shared.Services
{
    public interface IFormFactor
    {
        public string GetFormFactor();
        public string GetPlatform();

        public Task<double> SetDisplayColumns();
    }

    public interface ICustomAuthenticationStateProvider
    {
        public Task Login(string token);
        public Task Logout();
    }
}
