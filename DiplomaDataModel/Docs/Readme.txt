﻿==================== Enable-Migrations ==========================

Enable-Migrations -ContextTypeName DiplomaContext -MigrationsDirectory Migrations\Diploma

Enable-Migrations -ContextTypeName ApplicationDbContext -MigrationsDirectory Migrations\Identity

==================== Add-Migration ==============================c:\users\yadu\documents\visual studio 2015\Projects\w04a\Provinces\Provinces\Models\AccountViewModels.cs

add-migration -ConfigurationTypeName DiplomaOptions.Migrations.Diploma.Configuration "InitialCreate"
add-migration -ConfigurationTypeName DiplomaOptions.Migrations.Identity.Configuration "InitialCreate"

==================== update-database ==============================

update-database -ConfigurationTypeName DiplomaOptions.Migrations.Diploma.Configuration

update-database -ConfigurationTypeName DiplomaOptions.Migrations.Identity.Configuration

=============================================
