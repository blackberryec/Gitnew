namespace HaiShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "Quantitty", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CustomerMobile", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Orders", "CustomerMessage", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Orders", "PaymentMethod", c => c.String(maxLength: 256));
            AlterColumn("dbo.Orders", "PaymentStatus", c => c.String());
            AlterColumn("dbo.Products", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Slides", "Image", c => c.String(maxLength: 256));
            AlterColumn("dbo.Slides", "Url", c => c.String(maxLength: 256));
            AlterColumn("dbo.SupportOnlines", "Mobile", c => c.String(maxLength: 50));
            DropColumn("dbo.OrderDetails", "Quantity");
            DropColumn("dbo.Orders", "CustomerMessenge");
            DropColumn("dbo.Products", "CreateDate");
            DropColumn("dbo.Products", "UpdateDate");
            DropColumn("dbo.Products", "UpdateBy");
            DropColumn("dbo.ProductCategories", "CreateDate");
            DropColumn("dbo.ProductCategories", "UpdateDate");
            DropColumn("dbo.ProductCategories", "UpdateBy");
            DropColumn("dbo.Pages", "CreateDate");
            DropColumn("dbo.Pages", "UpdateDate");
            DropColumn("dbo.Pages", "UpdateBy");
            DropColumn("dbo.PostCategories", "CreateDate");
            DropColumn("dbo.PostCategories", "UpdateDate");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.Posts", "MoreImages");
            DropColumn("dbo.Posts", "CreateDate");
            DropColumn("dbo.Posts", "UpdateDate");
            DropColumn("dbo.Posts", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Posts", "MoreImages", c => c.String(storeType: "xml"));
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreateDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.Products", "CreateDate", c => c.DateTime());
            AddColumn("dbo.Orders", "CustomerMessenge", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.OrderDetails", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.SupportOnlines", "Mobile", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Slides", "Url", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.Slides", "Image", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
            AlterColumn("dbo.Products", "Alias", c => c.String(nullable: false, maxLength: 256, unicode: false));
            AlterColumn("dbo.Orders", "PaymentStatus", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "PaymentMethod", c => c.String(nullable: false, maxLength: 256));
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedDate");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "UpdatedDate");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.Pages", "UpdatedDate");
            DropColumn("dbo.Pages", "CreatedDate");
            DropColumn("dbo.ProductCategories", "UpdatedBy");
            DropColumn("dbo.ProductCategories", "UpdatedDate");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "UpdatedBy");
            DropColumn("dbo.Products", "UpdatedDate");
            DropColumn("dbo.Products", "CreatedDate");
            DropColumn("dbo.Orders", "CustomerMessage");
            DropColumn("dbo.Orders", "CustomerMobile");
            DropColumn("dbo.OrderDetails", "Quantitty");
        }
    }
}
