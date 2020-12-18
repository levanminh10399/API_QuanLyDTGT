namespace Doan_QLHTGT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
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
                        IdentityCard = c.String(),
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
            
            CreateTable(
                "dbo.ViPhams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoiDung = c.String(),
                        TienPhat = c.Int(nullable: false),
                        NgayViPham = c.DateTime(nullable: false),
                        NguoiDangKyXe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NguoiDangKyXes", t => t.NguoiDangKyXe_Id)
                .Index(t => t.NguoiDangKyXe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViPhams", "NguoiDangKyXe_Id", "dbo.NguoiDangKyXes");
            DropForeignKey("dbo.Xes", "NguoiDangKyXe_Id", "dbo.NguoiDangKyXes");
            DropIndex("dbo.ViPhams", new[] { "NguoiDangKyXe_Id" });
            DropIndex("dbo.Xes", new[] { "NguoiDangKyXe_Id" });
            DropTable("dbo.ViPhams");
            DropTable("dbo.Xes");
            DropTable("dbo.NguoiDangKyXes");
        }
    }
}
