namespace reFactorPrj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tFavorite")]
    public partial class tFavorite
    {
        [Key]
        public int fF_Id { get; set; }

        public int? fM_Id { get; set; }

        public int? fR_Id { get; set; }
    }
}
