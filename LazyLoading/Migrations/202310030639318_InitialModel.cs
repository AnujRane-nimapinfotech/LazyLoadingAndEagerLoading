namespace LazyLoading.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                {
                    AreaId = c.Int(nullable: false, identity: true),
                    AreaName = c.String(),
                    CityId = c.Int(nullable: false),
                    Pincode = c.String(),
                })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.Cities",
                c => new
                {
                    CityId = c.Int(nullable: false, identity: true),
                    CityName = c.String(),
                })
                .PrimaryKey(t => t.CityId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Areas", "CityId", "dbo.Cities");
            DropIndex("dbo.Areas", new[] { "CityId" });
            DropTable("dbo.Cities");
            DropTable("dbo.Areas");
        }
    }
}
