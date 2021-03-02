using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace reFactorPrj.Models
{
    public partial class reModel : DbContext
    {
        public reModel()
            : base("name=reModel")
        {
        }

        public virtual DbSet<tFavorite> tFavorite { get; set; }
        public virtual DbSet<tMembers> tMembers { get; set; }
        public virtual DbSet<tOrderDetail> tOrderDetail { get; set; }
        public virtual DbSet<tOrderMaster> tOrderMaster { get; set; }
        public virtual DbSet<tRecipe> tRecipe { get; set; }
        public virtual DbSet<tRecipeDetail> tRecipeDetail { get; set; }
        public virtual DbSet<tIngredients> tIngredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tRecipeDetail>()
                .Property(e => e.fRD_Dos)
                .HasPrecision(18, 1);

            modelBuilder.Entity<tIngredients>()
                .Property(e => e.fI_Price)
                .HasPrecision(18, 3);
        }
    }
}
