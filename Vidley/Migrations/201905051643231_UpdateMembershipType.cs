namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Paye as You Go' WHERE ID=1");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Monthly' WHERE ID=2");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Quaterly' WHERE ID=3");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME = 'Yearly' WHERE ID=4");            
        }
        
        public override void Down()
        {
        }
    }
}
