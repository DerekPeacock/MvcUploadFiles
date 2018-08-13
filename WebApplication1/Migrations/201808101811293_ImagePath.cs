namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePath : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "ImageURL", c => c.String(maxLength: 128));
        }
    }
}
