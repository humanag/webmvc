using BAL.Domain;
using DAL;
using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Implement
{
    public class HomeService: IHomeService
    {
        private IUnitOfWork _unitOfWork;

        public HomeService(IUnitOfWork unitOfWork)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
        }

        public SiteInfoDto GetSiteInfo()
        {
            var sysParam = (SysParamRepository)_unitOfWork.GetRepository<SysParam>();
            var items = sysParam.GetAll(x => x.Type == 0);
            // TODO - data demo.
            if (items.Count() < 1)
            {
                sysParam.Insert(
                    new SysParam()
                    {
                        Code = "Name",
                        Name = "Name",
                        Type = 0,
                        Value = "Minh Hoàng Đà Lạt"
                    });
                sysParam.Insert(
                    new SysParam()
                    {
                        Code = "Address",
                        Name = "Address",
                        Type = 0,
                        Value = "Lô G26, Trần Anh Tông, KQH Nguyên tử Lực, Phường 8, TP.Đà Lạt"
                    });
                sysParam.Insert(
                    new SysParam()
                    {
                        Code = "Province",
                        Name = "Province",
                        Type = 0,
                        Value = "Lâm Đồng"
                    });
                sysParam.Insert(
                    new SysParam()
                    {
                        Code = "Phone",
                        Name = "Phone",
                        Type = 0,
                        Value = "0931222775"
                    });
                sysParam.Insert(
                    new SysParam()
                    {
                        Code = "Phone2",
                        Name = "Phone2",
                        Type = 0,
                        Value = "0986909997"
                    });
                _unitOfWork.Save();

                items = sysParam.GetAll();
            }

            SiteInfoDto dto = new SiteInfoDto() {
                Name = items.Where(x => x.Code == "Name").FirstOrDefault<SysParam>()?.Value,
                Address = items.Where(x => x.Code == "Address").FirstOrDefault<SysParam>()?.Value,
                Province = items.Where(x => x.Code == "Province").FirstOrDefault<SysParam>()?.Value,
                Phone = items.Where(x => x.Code == "Phone").FirstOrDefault<SysParam>()?.Value,
                Phone2 = items.Where(x => x.Code == "Phone2").FirstOrDefault<SysParam>()?.Value,
        };
            
            return dto;
        }
    }
}
