using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webmvc.Models
{
    public class SiteInfoModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string FullAddress {
            get {
                return Address + ", " + Province;
            }
        }
        public string Phone { get; set; }
        public string Phone2 { get; set; }

    }
}