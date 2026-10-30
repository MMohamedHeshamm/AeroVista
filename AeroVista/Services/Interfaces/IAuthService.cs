using AeroVista.DTO;
using AeroVista.HelperModel;
using System.Threading.Tasks;

namespace AeroVista.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(Register model);
        Task<AuthModel> GetTokenAsync(Login model);
        Task<string> AddRoleAsync(AddRoleModel model);

    }
}