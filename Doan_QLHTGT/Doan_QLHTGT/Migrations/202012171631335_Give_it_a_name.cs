namespace Doan_QLHTGT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Give_it_a_name : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NguoiDangKyXes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Xes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoaiXe = c.String(),
                        BienSo = c.String(),
                        NguoiDangKyXe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NguoiDangKyXes", t => t.NguoiDangKyXe_Id)
                .Index(t => t.NguoiDangKyXe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Xes", "NguoiDangKyXe_Id", "dbo.NguoiDangKyXes");
            DropIndex("dbo.Xes", new[] { "NguoiDangKyXe_Id" });
            DropTable("dbo.Xes");
            DropTable("dbo.NguoiDangKyXes");
        }
    }
}
