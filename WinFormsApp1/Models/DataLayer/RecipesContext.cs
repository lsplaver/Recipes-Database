﻿using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using Recipes.Forms;
using Recipes.Objects;

namespace Recipes.Models.DataLayer;

public partial class RecipesContext : DbContext
{
    public RecipesContext()
    {
    }

    public RecipesContext(ServerObject server)
    {
        serverObject = server;
    }

    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingrediant> Ingrediants { get; set; }

    public virtual DbSet<Ingrediantalternatename> Ingrediantalternatenames { get; set; }

    public virtual DbSet<Ingrediantsubstitute> Ingrediantsubstitutes { get; set; }

    public virtual DbSet<Ingredianttype> Ingredianttypes { get; set; }

    public virtual DbSet<Koshertype> Koshertypes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<Recipecourse> Recipecourses { get; set; }

    public virtual DbSet<Recipesource> Recipesources { get; set; }

    public virtual DbSet<Recipesourcetype> Recipesourcetypes { get; set; }

    public virtual DbSet<Recipetype> Recipetypes { get; set; }

    private ConnectionStringSettings conn = new ConnectionStringSettings();
    //private App app;
    private string server, database, username, password;
    //private frmConnection.ControlCollection controlCollection = new Form.ControlCollection(owner: frmConnection);

    private ServerObject serverObject = new ServerObject();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\MSSQL\\MSSQL16.SQLSERVER\\MSSQL\\DATA\\Recipes.mdf; Integrated security=True");*/
    {
        if (!optionsBuilder.IsConfigured)
        {
            //if ((serverObject.Server != null) && (serverObject.Database != null) && (serverObject.Username != null) && (serverObject.Password != null))
            //{
                server = $"server={serverObject.Server};";
                database = $"database={serverObject.Database};";
                username = $"uid={serverObject.Username};";
                password = $"password={serverObject.Password};";
            //}
            //else
            //{
            //    frmConnection
            //    serverObject.Server = frmConnect.Server;
            //    serverObject.Database = frmConnect.Database;
            //    serverObject.Username = frmConnect.Username;
            //    serverObject.Password = frmConnect.Password;

            //    server = $"server={serverObject.Server};";
            //    database = $"database={serverObject.Database};";
            //    username = $"uid={serverObject.Username};";
            //    password = $"password={serverObject.Password};";
            //}
            //serverObject = ServerObject(server: frmConnect.Server, database: frmConnect.Database, username: frmConnect.Username, password: frmConnect.Password);

            /*server = $"server={serverObject.Server};";
            database = $"database={serverObject.Database};";
            username = $"uid={serverObject.Username};";
            password = $"password={serverObject.Password};";*/
            optionsBuilder.UseMySQL(conn.ConnectionString = server + database + username + password /*app.connectionString*/ /*ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString*/,
            providerOptions => providerOptions.EnableRetryOnFailure());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingrediant>(entity =>
        {
            entity.HasKey(e => e.IngrediantId).HasName("PRIMARY");

            entity.ToTable("ingrediants");

            entity.HasIndex(e => e.IngrediantTypeId, "FK_Ingrediants_IngrediantsID");

            entity.Property(e => e.IngrediantId).HasColumnName("IngrediantID");
            entity.Property(e => e.IngrediantName).HasColumnType("text");
            entity.Property(e => e.IngrediantTypeId).HasColumnName("IngrediantTypeID");

            entity.HasOne(d => d.IngrediantType).WithMany(p => p.Ingrediants)
                .HasForeignKey(d => d.IngrediantTypeId)
                .HasConstraintName("FK_Ingrediants_IngrediantsID");
        });

        modelBuilder.Entity<Ingrediantalternatename>(entity =>
        {
            entity.HasKey(e => e.AlternateNameId).HasName("PRIMARY");

            entity.ToTable("ingrediantalternatenames");

            entity.HasIndex(e => e.IngrediantNameId, "FK_IngrediantAlternateNames_IngrediantNameID");

            entity.Property(e => e.AlternateNameId).HasColumnName("AlternateNameID");
            entity.Property(e => e.AlternateName).HasColumnType("text");
            entity.Property(e => e.IngrediantNameId).HasColumnName("IngrediantNameID");

            entity.HasOne(d => d.IngrediantName).WithMany(p => p.Ingrediantalternatenames)
                .HasForeignKey(d => d.IngrediantNameId)
                .HasConstraintName("ingrediantalternatenames_ibfk_1");
        });

        modelBuilder.Entity<Ingrediantsubstitute>(entity =>
        {
            entity.HasKey(e => e.SubstitutedById).HasName("PRIMARY");

            entity.ToTable("ingrediantsubstitutes");

            entity.HasIndex(e => e.IngrediantNameId, "FK_IngrediantSubstitute_IngrediantNameID");

            entity.Property(e => e.SubstitutedById).HasColumnName("SubstitutedByID");
            entity.Property(e => e.IngrediantNameId).HasColumnName("IngrediantNameID");
            entity.Property(e => e.IngrediantSubstitutedById).HasColumnName("IngrediantSubstitutedByID");

            entity.HasOne(d => d.IngrediantName).WithMany(p => p.Ingrediantsubstitutes)
                .HasForeignKey(d => d.IngrediantNameId)
                .HasConstraintName("FK_IngrediantSubstitute_IngrediantNameID");
        });

        modelBuilder.Entity<Ingredianttype>(entity =>
        {
            entity.HasKey(e => e.IngrediantTypeId).HasName("PRIMARY");

            entity.ToTable("ingredianttypes");

            entity.Property(e => e.IngrediantTypeId).HasColumnName("IngrediantTypeID");
            entity.Property(e => e.IngrediantType1)
                .HasColumnType("text")
                .HasColumnName("IngrediantType");
        });

        modelBuilder.Entity<Koshertype>(entity =>
        {
            entity.HasKey(e => e.KosherTypeId).HasName("PRIMARY");

            entity.ToTable("koshertypes");

            entity.Property(e => e.KosherTypeId).HasColumnName("KosherTypeID");
            entity.Property(e => e.KosherTypeName).HasColumnType("text");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.RecipeId).HasName("PRIMARY");

            entity.ToTable("recipes");

            entity.HasIndex(e => e.CourseId, "FK_Recipes_CourseID").IsUnique();

            entity.HasIndex(e => e.IngrediantId, "FK_Recipes_IngrediantsID");

            entity.HasIndex(e => e.KosherTypeId, "FK_Recipes_KosherTypesID");

            entity.HasIndex(e => e.RecipeTypeId, "FK_Recipes_RecipeTypeID");

            entity.HasIndex(e => e.SourceId, "FK_Recipes_SourceID");

            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.IngrediantId).HasColumnName("IngrediantID");
            entity.Property(e => e.KosherTypeId).HasColumnName("KosherTypeID");
            entity.Property(e => e.RecipeName).HasColumnType("text");
            entity.Property(e => e.RecipeTypeId).HasColumnName("RecipeTypeID");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");

            entity.HasOne(d => d.Course).WithOne(p => p.Recipe)
                .HasForeignKey<Recipe>(d => d.CourseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("recipes_ibfk_1");

            entity.HasOne(d => d.Ingrediant).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.IngrediantId)
                .HasConstraintName("FK_Recipes_IngrediantsID");

            entity.HasOne(d => d.KosherType).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.KosherTypeId)
                .HasConstraintName("FK_Recipes_KosherTypesID");

            entity.HasOne(d => d.RecipeType).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.RecipeTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("recipes_ibfk_2");

            entity.HasOne(d => d.Source).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.SourceId)
                .HasConstraintName("FK_Recipes_SourceID");
        });

        modelBuilder.Entity<Recipecourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PRIMARY");

            entity.ToTable("recipecourse");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseName).HasColumnType("text");
        });

        modelBuilder.Entity<Recipesource>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PRIMARY");

            entity.ToTable("recipesources");

            entity.HasIndex(e => e.SourceTypeId, "FK_RecipeSources_SourceID");

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.SourceLocation).HasColumnType("text");
            entity.Property(e => e.SourceName).HasColumnType("text");
            entity.Property(e => e.SourceTypeId).HasColumnName("SourceTypeID");

            entity.HasOne(d => d.SourceType).WithMany(p => p.Recipesources)
                .HasForeignKey(d => d.SourceTypeId)
                .HasConstraintName("FK_RecipeSources_SourceID");
        });

        modelBuilder.Entity<Recipesourcetype>(entity =>
        {
            entity.HasKey(e => e.SourceTypeId).HasName("PRIMARY");

            entity.ToTable("recipesourcetypes");

            entity.Property(e => e.SourceTypeId).HasColumnName("SourceTypeID");
            entity.Property(e => e.SourceTypeName).HasColumnType("text");
        });

        modelBuilder.Entity<Recipetype>(entity =>
        {
            entity.HasKey(e => e.RecipeTypeId).HasName("PRIMARY");

            entity.ToTable("recipetype");

            entity.Property(e => e.RecipeTypeId).HasColumnName("RecipeTypeID");
            entity.Property(e => e.RecipeTypeName).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
