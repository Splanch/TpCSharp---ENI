namespace TP1_Mod6_Dojo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Samourais", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Samourais", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
