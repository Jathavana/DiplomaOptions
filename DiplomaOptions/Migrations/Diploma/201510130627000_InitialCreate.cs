namespace DiplomaOptions.Migrations.Diploma
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Choices",
                c => new
                    {
                        ChoiceId = c.Int(nullable: false, identity: true),
                        YearTermId = c.Int(nullable: false),
                        StudentId = c.String(nullable: false),
                        StudentFirstName = c.String(nullable: false, maxLength: 40),
                        StudentLastName = c.String(nullable: false, maxLength: 40),
                        FirstChoiceOptionId = c.Int(nullable: false),
                        SecondChoiceOptionId = c.Int(nullable: false),
                        ThirdChoiceOptionId = c.Int(nullable: false),
                        FourthChoiceOptionId = c.Int(nullable: false),
                        SelectionDate = c.DateTime(nullable: false),
                        FirstChoiceOption_OptionId = c.Int(),
                        FourthChoiceOption_OptionId = c.Int(),
                        SecondChoiceOption_OptionId = c.Int(),
                        ThirdChoiceOption_OptionId = c.Int(),
                    })
                .PrimaryKey(t => t.ChoiceId)
                .ForeignKey("dbo.Options", t => t.FirstChoiceOption_OptionId)
                .ForeignKey("dbo.Options", t => t.FourthChoiceOption_OptionId)
                .ForeignKey("dbo.Options", t => t.SecondChoiceOption_OptionId)
                .ForeignKey("dbo.Options", t => t.ThirdChoiceOption_OptionId)
                .ForeignKey("dbo.YearTerms", t => t.YearTermId, cascadeDelete: true)
                .Index(t => t.YearTermId)
                .Index(t => t.FirstChoiceOption_OptionId)
                .Index(t => t.FourthChoiceOption_OptionId)
                .Index(t => t.SecondChoiceOption_OptionId)
                .Index(t => t.ThirdChoiceOption_OptionId);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OptionId);
            
            CreateTable(
                "dbo.YearTerms",
                c => new
                    {
                        YearTermId = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Term = c.Int(nullable: false),
                        isDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YearTermId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Choices", "YearTermId", "dbo.YearTerms");
            DropForeignKey("dbo.Choices", "ThirdChoiceOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "SecondChoiceOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "FourthChoiceOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "FirstChoiceOption_OptionId", "dbo.Options");
            DropIndex("dbo.Choices", new[] { "ThirdChoiceOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "SecondChoiceOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "FourthChoiceOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "FirstChoiceOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "YearTermId" });
            DropTable("dbo.YearTerms");
            DropTable("dbo.Options");
            DropTable("dbo.Choices");
        }
    }
}
