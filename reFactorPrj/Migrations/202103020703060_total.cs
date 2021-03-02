namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class total : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tRecipeDetail", "Total", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tRecipeDetail", "Total");
        }
    }
}
