using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Thblesson09.Models.DataModels.DataViewModels
{
    public class ThbMemberregister
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string ThbUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string ThbPassword { get; set; }

        [DisplayName("Email")]
        public string ThbEmail { get; set; }

        [DisplayName("Số điện thoại")]
        public string ThbPhoneNumber { get; set; }

        [DisplayName("Họ và tên")]
        public string ThbFullName { get; set; }

        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime ThbBirthday { get; set; }
    }
}