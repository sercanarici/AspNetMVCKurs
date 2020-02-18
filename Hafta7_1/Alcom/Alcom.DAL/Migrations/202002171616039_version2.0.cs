namespace Alcom.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version20 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medya",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(nullable: false),
                        UrunId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(),
                        SilindiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medya", "UrunId", "dbo.Urun");
            DropIndex("dbo.Medya", new[] { "UrunId" });
            DropTable("dbo.Medya");
        }
    }
}
