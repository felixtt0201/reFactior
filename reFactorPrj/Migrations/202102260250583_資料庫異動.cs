namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class 資料庫異動 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tRecipeDetail", "Name", c => c.String());
            AddColumn("dbo.tRecipeDetail", "Price", c => c.Int(nullable: false));
            CreateIndex("dbo.tRecipeDetail", "fR_Id");
            AddForeignKey("dbo.tRecipeDetail", "fR_Id", "dbo.tRecipe", "fR_Id");
            DropColumn("dbo.tRecipeDetail", "ft_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tRecipeDetail", "ft_Id", c => c.Int());
            DropForeignKey("dbo.tRecipeDetail", "fR_Id", "dbo.tRecipe");
            DropIndex("dbo.tRecipeDetail", new[] { "fR_Id" });
            DropColumn("dbo.tRecipeDetail", "Price");
            DropColumn("dbo.tRecipeDetail", "Name");
        }
    }
}
