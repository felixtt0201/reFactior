namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tRecipeDetail")]
    public partial class tRecipeDetail
    {
        [Key]
        public int fRD_Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fRD_Dos { get; set; }

        [StringLength(5)]
        public string fRD_Unit { get; set; }

        public int Price { get; set; }
        public int? fR_Id { get; set; }
        [ForeignKey("fR_Id")]
        public virtual tRecipe tRecipe  { get; set; }
    }
}
