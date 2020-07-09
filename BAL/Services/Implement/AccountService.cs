using BAL.Domain;
using BAL.Models;
using DAL;
using DAL.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BAL.Services.Implement
{
    public class AccountService : IAccountService
    {
        private IUnitOfWork _unitOfWork;
        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public LoginUser Login(LoginViewModel model)
        {
            LoginUser login = new LoginUser();
            login.Status = 0;
            var account = _unitOfWork.GetRepository<SysUser>()
                .Get(x => x.UserName == model.UserName || x.Email == model.UserName);
            if (account == null)
                return login;

            login.Id = account.Id;
            login.UserName = account.UserName;
            login.FullName = account.FullName;

            if (account.PassWD != model.Password)
                login.Status = 2;
            else
                login.Status = 1;

            return login;
        }
    }
}
