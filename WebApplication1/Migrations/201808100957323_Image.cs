namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ImageURL", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ImageURL");
        }
    }
}
