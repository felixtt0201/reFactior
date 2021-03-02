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

        [DisplayName("�m�W")]
        [StringLength(50)]
        [Required]
        public string fM_Name { get; set; }

        [DisplayName("�q��")]
        [StringLength(50)]
        public string fM_Phone { get; set; }

        [DisplayName("�ʧO")]
        public Gender fM_Gender { get; set; }

        [DisplayName("�q�l�H�c(�b��)")]
        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string fM_Email { get; set; }

        [DisplayName("�a�}")]
        public string fM_Address { get; set; }

        [DisplayName("�K�X")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required]
        public string fM_Password { get; set; }
    }

    public class Login
    {
        [DisplayName("�q�l�H�c(�b��)")]
        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string fM_Email { get; set; }

        [DisplayName("�K�X")]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Required]
        public string fM_Password { get; set; }
    }
}
