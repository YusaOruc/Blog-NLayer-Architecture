﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added_message_date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "MessageDate");
        }
    }
}
