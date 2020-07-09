using System.ComponentModel.DataAnnotations;

namespace BAL.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Phải nhập tên đăng nhập")]
        public string UserName { get; set; }
        
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class LoginUser
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string StatusText { get; set; }
        /// <summary>
        /// 0: khong thanh cong
        /// 1: Thanh cong
        /// 2: Bi khoa, chua kich hoat ...
        /// </summary>
        public int Status { get; set; }
    }
}