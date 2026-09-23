using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Thblesson09.Models.DataModels
{
    public class ThbMember
    {
        public int ThbMemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="Tên đăng nhập không thể trống ")]
        [StringLength(20,MinimumLength = 3,ErrorMessage ="Tên đăng nhập có độ dài khoảng 1-30 ký tự ")]
        public string ThbUserName { get; set; }

        [DisplayName("Mật khẩu ")]
        [Required(ErrorMessage = "Mật khẩu  không thể trống ")]
        [DataType(DataType.Password)]
        public string ThbPassword { get; set; }
        public string ThbEmail { get; set; }
        public string ThbPhoneNumber { get; set; }
        public string ThbFullName { get; set; }
        public DateTime ThbBirthday { get; set; }
    }
}
