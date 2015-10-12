namespace DiplomaOptions.Migrations.Diploma
{
    using DiplomaDataModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DiplomaDataModel.DiplomaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Diploma";
        }

        protected override void Seed(DiplomaDataModel.DiplomaContext context)
        {
            List<Option> Options = new List<Option>();
            Options.Add(new Option()
            {
                Title = "Data Communications",
                IsActive = true
            });

            Options.Add(new Option()
            {
                Title = "Client Server",
                IsActive = true
            });

            Options.Add(new Option()
            {
                Title = "Digital Processing",
                IsActive = true
            });

            Options.Add(new Option()
            {
                Title = "Information Systems",
                IsActive = true
            });

            Options.Add(new Option()
            {
                Title = "Database",
                IsActive = false
            });


            Options.Add(new Option()
            {
                Title = "Web & Mobile",
                IsActive = true
            });

            Options.Add(new Option()
            {
                Title = "Tech Pro",
                IsActive = false
            });

            context.Options.AddRange(Options);
            context.SaveChanges();

            List<YearTerm> YearTerms = new List<YearTerm>();

            YearTerms.Add(new YearTerm()
            {
                Year = 2015,
                Term = 10,
                isDefault = false
            });

            YearTerms.Add(new YearTerm()
            {
                Year = 2015,
                Term = 20,
                isDefault = false
            });

            YearTerms.Add(new YearTerm()
            {
                Year = 2015,
                Term = 30,
                isDefault = false
            });

            YearTerms.Add(new YearTerm()
            {
                Year = 2016,
                Term = 10,
                isDefault = true
            });

            context.YearTerms.AddRange(YearTerms);
            context.SaveChanges();
        }
    }
}
