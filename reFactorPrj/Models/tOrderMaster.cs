namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tOrderMaster")]
    public partial class tOrderMaster
    {
        [Key]
        [StringLength(50)]
        public string fO_Id { get; set; }

        [StringLength(50)]
        public string fO_OrderDate { get; set; }

        public int? fM_Id { get; set; }

        public int? fO_Total { get; set; }

        public bool? fO_Finished { get; set; }
    }
}
