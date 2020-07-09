using BAL.Domain;
using System.Threading.Tasks;

namespace BAL.Services
{
    public interface IParamService
    {
        SiteInfoDto Get();
        Task<bool> Update(SiteInfoDto dto, int uid = 0);
    }
}
