namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tRecipe")]
    public partial class tRecipe
    {
        [Key]
        public int fR_Id { get; set; }

        [StringLength(10)]
        public string fR_Type { get; set; }

        public int? fRD_Serving { get; set; }

        [StringLength(50)]
        public string fR_Menu { get; set; }

        public string fR_Do { get; set; }

        [StringLength(51)]
        public string fR_Pic { get; set; }

        // 一對多關聯
        public virtual  ICollection<tRecipeDetail> tRecipeDetail { get; set; }

    }
}
