namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tOrderDetail")]
    public partial class tOrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string fO_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int fM_No { get; set; }

        public int? fI_Id { get; set; }

        public int? fQty { get; set; }

        [StringLength(10)]
        public string fRD_Unit { get; set; }

        public bool? fOD_Check { get; set; }

        public int? fR_Id { get; set; }

        [StringLength(50)]
        public string fRD_Ingredients { get; set; }
    }
}
