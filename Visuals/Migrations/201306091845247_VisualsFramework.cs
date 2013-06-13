namespace Visuals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VisualsFramework : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MiniAvatar = c.String(maxLength: 4000),
                        Link = c.String(maxLength: 4000),
                        Name = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(maxLength: 4000),
                        Person_Id = c.Int(),
                        Article_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.Articles", t => t.Article_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Article_Id);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Thumbnail = c.String(maxLength: 4000),
                        Link = c.String(maxLength: 4000),
                        Title = c.String(maxLength: 4000),
                        Synopsis = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(maxLength: 4000),
                        Title = c.String(maxLength: 4000),
                        Person_Id = c.Int(),
                        Person_Id1 = c.Int(),
                        Person_Id2 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.People", t => t.Person_Id1)
                .ForeignKey("dbo.People", t => t.Person_Id2)
                .Index(t => t.Person_Id)
                .Index(t => t.Person_Id1)
                .Index(t => t.Person_Id2);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(maxLength: 4000),
                        Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .Index(t => t.Post_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            DropIndex("dbo.Pics", new[] { "Person_Id2" });
            DropIndex("dbo.Pics", new[] { "Person_Id1" });
            DropIndex("dbo.Pics", new[] { "Person_Id" });
            DropIndex("dbo.Posts", new[] { "Article_Id" });
            DropIndex("dbo.Posts", new[] { "Person_Id" });
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Pics", "Person_Id2", "dbo.People");
            DropForeignKey("dbo.Pics", "Person_Id1", "dbo.People");
            DropForeignKey("dbo.Pics", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Posts", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.Posts", "Person_Id", "dbo.People");
            DropTable("dbo.Comments");
            DropTable("dbo.Pics");
            DropTable("dbo.Articles");
            DropTable("dbo.Posts");
            DropTable("dbo.People");
        }
    }
}
