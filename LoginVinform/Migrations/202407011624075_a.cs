namespace LoginVinform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullanıcıAdı = c.String(nullable: false),
                        TelefonNo = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adres = c.String(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullanıcıAdı = c.String(),
                        TelefonNo = c.String(),
                        Sifre = c.String(),
                        Email = c.String(),
                        Adres = c.String(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserItems");
            DropTable("dbo.StaffItems");
        }
    }
}
