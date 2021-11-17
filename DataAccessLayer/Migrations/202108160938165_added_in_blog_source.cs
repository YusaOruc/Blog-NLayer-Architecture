namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_in_blog_source : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Source", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Source");
        }
    }
}
