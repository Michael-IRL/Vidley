namespace Vidley.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEMBERSHIPTYPES (Id,SingUpFee,DurationInMonths,DiscountRate) Values (1,0,0,0)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id,SingUpFee,DurationInMonths,DiscountRate) Values (2,30,1,10)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id,SingUpFee,DurationInMonths,DiscountRate) Values (3,90,1,15)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id,SingUpFee,DurationInMonths,DiscountRate) Values (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
