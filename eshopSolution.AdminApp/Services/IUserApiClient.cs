using eShopSolution.ViewModels.System.Users;
using System.Threading.Tasks;

namespace eshopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
