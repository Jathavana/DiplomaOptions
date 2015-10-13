namespace DiplomaOptions.Migrations.Diploma
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStudentIDinChoices : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Choices", "Option_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "FourthChoiceOption_OptionId", "dbo.Options");
            DropIndex("dbo.Choices", new[] { "Option_OptionId" });
            DropIndex("dbo.Choices", new[] { "FourthChoiceOption_OptionId" });
            DropColumn("dbo.Choices", "FourthChoiceOptionId");
            RenameColumn(table: "dbo.Choices", name: "FourthChoiceOption_OptionId", newName: "FourthChoiceOptionId");
            AlterColumn("dbo.Choices", "StudentId", c => c.String(nullable: false));
            AlterColumn("dbo.Choices", "FourthChoiceOptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Choices", "FourthChoiceOptionId");
            AddForeignKey("dbo.Choices", "FourthChoiceOptionId", "dbo.Options", "OptionId", cascadeDelete: true);
            DropColumn("dbo.Choices", "Option_OptionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Choices", "Option_OptionId", c => c.Int());
            DropForeignKey("dbo.Choices", "FourthChoiceOptionId", "dbo.Options");
            DropIndex("dbo.Choices", new[] { "FourthChoiceOptionId" });
            AlterColumn("dbo.Choices", "FourthChoiceOptionId", c => c.Int());
            AlterColumn("dbo.Choices", "StudentId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Choices", name: "FourthChoiceOptionId", newName: "FourthChoiceOption_OptionId");
            AddColumn("dbo.Choices", "FourthChoiceOptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Choices", "FourthChoiceOption_OptionId");
            CreateIndex("dbo.Choices", "Option_OptionId");
            AddForeignKey("dbo.Choices", "FourthChoiceOption_OptionId", "dbo.Options", "OptionId");
            AddForeignKey("dbo.Choices", "Option_OptionId", "dbo.Options", "OptionId");
        }
    }
}
