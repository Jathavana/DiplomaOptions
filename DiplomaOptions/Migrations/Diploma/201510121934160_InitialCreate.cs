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
                        StudentId = c.Int(nullable: false),
                        StudentFirstName = c.String(nullable: false, maxLength: 40),
                        StudentLastName = c.String(nullable: false, maxLength: 40),
                        FirstChoiceOptionId = c.Int(nullable: false),
                        SecondChoiceOptionId = c.Int(nullable: false),
                        ThirdChoiceOptionId = c.Int(nullable: false),
                        FourthChoiceOptionId = c.Int(nullable: false),
                        SelectionDate = c.DateTime(nullable: false),
                        Option_OptionId = c.Int(),
                        FirstOption_OptionId = c.Int(),
                        FourthOption_OptionId = c.Int(),
                        SecondOption_OptionId = c.Int(),
                        ThirdOption_OptionId = c.Int(),
                    })
                .PrimaryKey(t => t.ChoiceId)
                .ForeignKey("dbo.Options", t => t.Option_OptionId)
                .ForeignKey("dbo.Options", t => t.FirstOption_OptionId)
                .ForeignKey("dbo.Options", t => t.FourthOption_OptionId)
                .ForeignKey("dbo.Options", t => t.SecondOption_OptionId)
                .ForeignKey("dbo.Options", t => t.ThirdOption_OptionId)
                .ForeignKey("dbo.YearTerms", t => t.YearTermId, cascadeDelete: true)
                .Index(t => t.YearTermId)
                .Index(t => t.Option_OptionId)
                .Index(t => t.FirstOption_OptionId)
                .Index(t => t.FourthOption_OptionId)
                .Index(t => t.SecondOption_OptionId)
                .Index(t => t.ThirdOption_OptionId);
            
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
            DropForeignKey("dbo.Choices", "ThirdOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "SecondOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "FourthOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "FirstOption_OptionId", "dbo.Options");
            DropForeignKey("dbo.Choices", "Option_OptionId", "dbo.Options");
            DropIndex("dbo.Choices", new[] { "ThirdOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "SecondOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "FourthOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "FirstOption_OptionId" });
            DropIndex("dbo.Choices", new[] { "Option_OptionId" });
            DropIndex("dbo.Choices", new[] { "YearTermId" });
            DropTable("dbo.YearTerms");
            DropTable("dbo.Options");
            DropTable("dbo.Choices");
        }
    }
}
