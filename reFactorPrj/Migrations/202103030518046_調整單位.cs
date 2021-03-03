namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 調整單位 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tRecipeDetail", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tRecipeDetail", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tRecipeDetail", "Total", c => c.Int(nullable: false));
            AlterColumn("dbo.tRecipeDetail", "Price", c => c.Int(nullable: false));
        }
    }
}
