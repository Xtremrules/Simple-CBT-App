namespace CBT.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BatchNotNeeded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SQuestion", "BatchID", "dbo.Batch");
            DropIndex("dbo.SQuestion", new[] { "BatchID" });
            CreateTable(
                "dbo.SQuestionBatch",
                c => new
                    {
                        SquestionID = c.Int(nullable: false),
                        BatchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SquestionID, t.BatchID })
                .ForeignKey("dbo.SQuestion", t => t.SquestionID, cascadeDelete: true)
                .ForeignKey("dbo.Batch", t => t.BatchID, cascadeDelete: true)
                .Index(t => t.SquestionID)
                .Index(t => t.BatchID);
            
            DropColumn("dbo.SQuestion", "BatchID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SQuestion", "BatchID", c => c.Int(nullable: false));
            DropForeignKey("dbo.SQuestionBatch", "BatchID", "dbo.Batch");
            DropForeignKey("dbo.SQuestionBatch", "SquestionID", "dbo.SQuestion");
            DropIndex("dbo.SQuestionBatch", new[] { "BatchID" });
            DropIndex("dbo.SQuestionBatch", new[] { "SquestionID" });
            DropTable("dbo.SQuestionBatch");
            CreateIndex("dbo.SQuestion", "BatchID");
            AddForeignKey("dbo.SQuestion", "BatchID", "dbo.Batch", "ID", cascadeDelete: true);
        }
    }
}
