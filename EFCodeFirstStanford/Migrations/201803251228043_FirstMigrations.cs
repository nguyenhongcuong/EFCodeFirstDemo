namespace EFCodeFirstStanford.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNv = c.String(nullable: false, maxLength: 10),
                        HoTen = c.String(maxLength: 30),
                        NgaySinh = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.MaNv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanVien");
        }
    }
}
