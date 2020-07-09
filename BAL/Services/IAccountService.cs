using BAL.Domain;
using BAL.Models;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IAccountService
    {
        LoginUser Login(LoginViewModel model);
    }
}
