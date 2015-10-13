namespace DiplomaOptions.Migrations.Diploma
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChoiceNameChanges : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Choices", name: "FirstOption_OptionId", newName: "FirstChoiceOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "FourthOption_OptionId", newName: "FourthChoiceOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "SecondOption_OptionId", newName: "SecondChoiceOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "ThirdOption_OptionId", newName: "ThirdChoiceOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_FirstOption_OptionId", newName: "IX_FirstChoiceOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_FourthOption_OptionId", newName: "IX_FourthChoiceOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_SecondOption_OptionId", newName: "IX_SecondChoiceOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_ThirdOption_OptionId", newName: "IX_ThirdChoiceOption_OptionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Choices", name: "IX_ThirdChoiceOption_OptionId", newName: "IX_ThirdOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_SecondChoiceOption_OptionId", newName: "IX_SecondOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_FourthChoiceOption_OptionId", newName: "IX_FourthOption_OptionId");
            RenameIndex(table: "dbo.Choices", name: "IX_FirstChoiceOption_OptionId", newName: "IX_FirstOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "ThirdChoiceOption_OptionId", newName: "ThirdOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "SecondChoiceOption_OptionId", newName: "SecondOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "FourthChoiceOption_OptionId", newName: "FourthOption_OptionId");
            RenameColumn(table: "dbo.Choices", name: "FirstChoiceOption_OptionId", newName: "FirstOption_OptionId");
        }
    }
}
