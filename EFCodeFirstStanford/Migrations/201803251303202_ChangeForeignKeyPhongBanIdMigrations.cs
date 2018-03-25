namespace EFCodeFirstStanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeForeignKeyPhongBanIdMigrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NhanVien", "PhongBanId");
            RenameColumn(table: "dbo.NhanVien", name: "PhongBan_MaPhong", newName: "PhongBanId");
            RenameIndex(table: "dbo.NhanVien", name: "IX_PhongBan_MaPhong", newName: "IX_PhongBanId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.NhanVien", name: "IX_PhongBanId", newName: "IX_PhongBan_MaPhong");
            RenameColumn(table: "dbo.NhanVien", name: "PhongBanId", newName: "PhongBan_MaPhong");
            AddColumn("dbo.NhanVien", "PhongBanId", c => c.String(maxLength: 10));
        }
    }
}
