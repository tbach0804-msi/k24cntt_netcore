using System;
using System.ComponentModel.DataAnnotations;

namespace TrinhHoangBach2410900008_exam.Models
{
    public class ThbStudent
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Họ và tên")]
        public string ThbName { get; set; } = string.Empty;

        [Display(Name = "Giới tính")]
        public bool ThbGender { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime ThbBirthDay { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string? ThbEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        public string? ThbPhone { get; set; }

        [Display(Name = "Trạng thái")]
        public bool ThbActive { get; set; }
    }
}