namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tIngredients
    {
        [Key]
        public int fI_Id { get; set; }

        [StringLength(10)]
        public string fRD_Type { get; set; }

        [StringLength(50)]
        public string fRD_Ingredients { get; set; }

        [StringLength(5)]
        public string fRD_Unit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal fI_Price { get; set; }
    }
}