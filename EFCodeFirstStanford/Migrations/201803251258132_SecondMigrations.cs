namespace EFCodeFirstStanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhongBan",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 10),
                        TenPhong = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            AddColumn("dbo.NhanVien", "PhongBanId", c => c.String(maxLength: 10));
            AddColumn("dbo.NhanVien", "PhongBan_MaPhong", c => c.String(maxLength: 10));
            CreateIndex("dbo.NhanVien", "PhongBan_MaPhong");
            AddForeignKey("dbo.NhanVien", "PhongBan_MaPhong", "dbo.PhongBan", "MaPhong");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanVien", "PhongBan_MaPhong", "dbo.PhongBan");
            DropIndex("dbo.NhanVien", new[] { "PhongBan_MaPhong" });
            DropColumn("dbo.NhanVien", "PhongBan_MaPhong");
            DropColumn("dbo.NhanVien", "PhongBanId");
            DropTable("dbo.PhongBan");
        }
    }
}
