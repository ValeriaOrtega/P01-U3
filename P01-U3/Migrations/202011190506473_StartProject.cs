namespace P01_U3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Película = c.String(),
                        Horario = c.DateTime(nullable: false),
                        Duración = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cines");
        }
    }
}
