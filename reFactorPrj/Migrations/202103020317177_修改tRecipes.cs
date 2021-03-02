namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 修改tRecipes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tRecipe", "fRD_Serving", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tRecipe", "fRD_Serving", c => c.Int());
        }
    }
}
