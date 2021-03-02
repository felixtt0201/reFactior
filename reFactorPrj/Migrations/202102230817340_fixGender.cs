namespace reFactorPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixGender : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tFavorite",
                c => new
                    {
                        fF_Id = c.Int(nullable: false, identity: true),
                        fM_Id = c.Int(),
                        fR_Id = c.Int(),
                    })
                .PrimaryKey(t => t.fF_Id);
            
            CreateTable(
                "dbo.tIngredients",
                c => new
                    {
                        fI_Id = c.Int(nullable: false, identity: true),
                        fRD_Type = c.String(maxLength: 10),
                        fRD_Ingredients = c.String(maxLength: 50),
                        fRD_Unit = c.String(maxLength: 5),
                        fI_Price = c.Decimal(precision: 18, scale: 3, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.fI_Id);
            
            CreateTable(
                "dbo.tMembers",
                c => new
                    {
                        fM_Id = c.Int(nullable: false, identity: true),
                        fM_Name = c.String(nullable: false, maxLength: 50),
                        fM_Phone = c.String(maxLength: 50),
                        fM_Gender = c.Int(nullable: false),
                        fM_Email = c.String(nullable: false, maxLength: 50),
                        fM_Address = c.String(),
                        fM_Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.fM_Id);
            
            CreateTable(
                "dbo.tOrderDetail",
                c => new
                    {
                        fO_Id = c.String(nullable: false, maxLength: 50),
                        fM_No = c.Int(nullable: false),
                        fI_Id = c.Int(),
                        fQty = c.Int(),
                        fRD_Unit = c.String(maxLength: 10),
                        fOD_Check = c.Boolean(),
                        fR_Id = c.Int(),
                        fRD_Ingredients = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.fO_Id, t.fM_No });
            
            CreateTable(
                "dbo.tOrderMaster",
                c => new
                    {
                        fO_Id = c.String(nullable: false, maxLength: 50),
                        fO_OrderDate = c.String(maxLength: 50),
                        fM_Id = c.Int(),
                        fO_Total = c.Int(),
                        fO_Finished = c.Boolean(),
                    })
                .PrimaryKey(t => t.fO_Id);
            
            CreateTable(
                "dbo.tRecipe",
                c => new
                    {
                        fR_Id = c.Int(nullable: false, identity: true),
                        fR_Type = c.String(maxLength: 10),
                        fRD_Serving = c.Int(),
                        fR_Menu = c.String(maxLength: 50),
                        fR_Do = c.String(),
                        fR_Pic = c.String(maxLength: 51),
                    })
                .PrimaryKey(t => t.fR_Id);
            
            CreateTable(
                "dbo.tRecipeDetail",
                c => new
                    {
                        fRD_Id = c.Int(nullable: false, identity: true),
                        fR_Id = c.Int(),
                        ft_Id = c.Int(),
                        fRD_Dos = c.Decimal(precision: 18, scale: 1, storeType: "numeric"),
                        fRD_Unit = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.fRD_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tRecipeDetail");
            DropTable("dbo.tRecipe");
            DropTable("dbo.tOrderMaster");
            DropTable("dbo.tOrderDetail");
            DropTable("dbo.tMembers");
            DropTable("dbo.tIngredients");
            DropTable("dbo.tFavorite");
        }
    }
}
