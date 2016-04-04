namespace GameData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BattleLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Part = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        HitValue = c.Int(nullable: false),
                        FirstPlayer_Id = c.Long(),
                        SecondPlayer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_Id)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_Id)
                .Index(t => t.FirstPlayer_Id)
                .Index(t => t.SecondPlayer_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Name = c.String(),
                        Hp = c.Int(nullable: false),
                        MaxHP = c.Int(nullable: false),
                        Damage = c.Int(nullable: false),
                        Experience = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Battles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        LogId = c.Long(nullable: false),
                        Result = c.Int(nullable: false),
                        ExpGained = c.Int(nullable: false),
                        FirstPlayer_Id = c.Long(),
                        SecondPlayer_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_Id)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_Id)
                .Index(t => t.FirstPlayer_Id)
                .Index(t => t.SecondPlayer_Id);
            
            CreateTable(
                "dbo.UserBillingTransactions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TransactionId = c.Guid(nullable: false),
                        Description = c.String(),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        User_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        EMail = c.String(),
                        IsEMailValid = c.Boolean(nullable: false),
                        Player = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBillingTransactions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Battles", "SecondPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Battles", "FirstPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.BattleLogs", "SecondPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.BattleLogs", "FirstPlayer_Id", "dbo.Players");
            DropIndex("dbo.UserBillingTransactions", new[] { "User_Id" });
            DropIndex("dbo.Battles", new[] { "SecondPlayer_Id" });
            DropIndex("dbo.Battles", new[] { "FirstPlayer_Id" });
            DropIndex("dbo.BattleLogs", new[] { "SecondPlayer_Id" });
            DropIndex("dbo.BattleLogs", new[] { "FirstPlayer_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserBillingTransactions");
            DropTable("dbo.Battles");
            DropTable("dbo.Players");
            DropTable("dbo.BattleLogs");
        }
    }
}
