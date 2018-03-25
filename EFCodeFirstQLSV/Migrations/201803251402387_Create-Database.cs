namespace EFCodeFirstQLSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KetQuaThis",
                c => new
                    {
                        MaSv = c.String(nullable: false, maxLength: 10),
                        MaMon = c.String(nullable: false, maxLength: 10),
                        DiemThi = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaSv, t.MaMon })
                .ForeignKey("dbo.MonHocs", t => t.MaMon, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.MaSv, cascadeDelete: true)
                .Index(t => t.MaSv)
                .Index(t => t.MaMon);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MaMon = c.String(nullable: false, maxLength: 10),
                        TenMon = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaMon);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSv = c.String(nullable: false, maxLength: 10),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        MaLop = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaSv)
                .ForeignKey("dbo.LopHocs", t => t.MaLop)
                .Index(t => t.MaLop);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 10),
                        TenLop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs");
            DropForeignKey("dbo.KetQuaThis", "MaSv", "dbo.SinhViens");
            DropForeignKey("dbo.KetQuaThis", "MaMon", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropIndex("dbo.KetQuaThis", new[] { "MaMon" });
            DropIndex("dbo.KetQuaThis", new[] { "MaSv" });
            DropTable("dbo.LopHocs");
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.KetQuaThis");
        }
    }
}
