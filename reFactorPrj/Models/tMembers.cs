namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tMembers
    {
        [Key]
        public int fM_Id { get; set; }

        [DisplayName("姓名")]
        [StringLength(50)]
        [Required]
        public string fM_Name { get; set; }

        [DisplayName("電話")]
        [StringLength(50)]
        public string fM_Phone { get; set; }

        [DisplayName("性別")]
        public Gender fM_Gender { get; set; }

        [DisplayName("電子信箱(帳號)")]
        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string fM_Email { get; set; }

        [DisplayName("地址")]
        public string fM_Address { get; set; }

        [DisplayName("密碼")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required]
        public string fM_Password { get; set; }
    }

    public class Login
    {
        [DisplayName("電子信箱(帳號)")]
        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string fM_Email { get; set; }

        [DisplayName("密碼")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required]
        public string fM_Password { get; set; }
    }
}
