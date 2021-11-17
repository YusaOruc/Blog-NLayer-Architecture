namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added_BlogTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogHeader", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogHeader");
        }
    }
}
