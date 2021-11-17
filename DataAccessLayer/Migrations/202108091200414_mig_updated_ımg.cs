namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_updated_ımg : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Homes", "Img", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Homes", "Img", c => c.Int(nullable: false));
        }
    }
}
