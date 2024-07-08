

namespace MauiAppStockTaking.Services
{
    public class MockAuthService : IAuthService    {
        public Task<bool> LoginAsync() => Task.FromResult(true);
    }

}
