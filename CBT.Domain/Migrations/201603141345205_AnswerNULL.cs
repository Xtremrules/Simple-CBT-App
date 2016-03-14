namespace CBT.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnswerNULL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Question", "Answer", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Question", "Answer", c => c.Int(nullable: false));
        }
    }
}
