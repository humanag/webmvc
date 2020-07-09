using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BAL.Domain
{
    public class SiteInfoDto
    {

        [DisplayName("Tên doanh nghiệp")]
        public string Name { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("Tỉnh/TP")]
        public string Province { get; set; }

        [DisplayName("Địa chỉ")]
        public string FullAddress {
            get {
                return Address + ", " + Province;
            }
        }
        [DisplayName("Điện thoại")]
        public string Phone { get; set; }

        [DisplayName("Điện thoại")]
        public string Phone2 { get; set; }

    }
}