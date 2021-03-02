namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tIngredients", "fI_Price", c => c.Decimal(nullable: false, precision: 18, scale: 3, storeType: "numeric"));
            AlterColumn("dbo.tRecipe", "fR_Pic", c => c.String());
            AlterColumn("dbo.tRecipeDetail", "fRD_Dos", c => c.Decimal(nullable: false, precision: 18, scale: 1, storeType: "numeric"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tRecipeDetail", "fRD_Dos", c => c.Decimal(precision: 18, scale: 1, storeType: "numeric"));
            AlterColumn("dbo.tRecipe", "fR_Pic", c => c.String(maxLength: 51));
            AlterColumn("dbo.tIngredients", "fI_Price", c => c.Decimal(precision: 18, scale: 3, storeType: "numeric"));
        }
    }
}
