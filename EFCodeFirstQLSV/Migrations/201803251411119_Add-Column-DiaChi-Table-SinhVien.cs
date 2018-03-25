namespace EFCodeFirstQLSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnDiaChiTableSinhVien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "DiaChi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "DiaChi");
        }
    }
}
