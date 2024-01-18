using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models.DataLayer;

public partial class RecipesContext : DbContext
{
    public RecipesContext()
    {
    }

    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingrediant> Ingrediants { get; set; }

    public virtual DbSet<Ingrediantsubstitute> Ingrediantsubstitutes { get; set; }

    public virtual DbSet<Ingredianttype> Ingredianttypes { get; set; }

    public virtual DbSet<Koshertype> Koshertypes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<Recipesource> Recipesources { get; set; }

    public virtual DbSet<Recipesourcetype> Recipesourcetypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\MSSQL\\MSSQL16.SQLSERVER\\MSSQL\\DATA\\Recipes.mdf; Integrated security=True");*/
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString,
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingrediants_IngrediantsID");
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
                .OnDelete(DeleteBehavior.ClientSetNull)
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

            entity.HasIndex(e => e.IngrediantId, "FK_Recipes_IngrediantsID");

            entity.HasIndex(e => e.KosherTypeId, "FK_Recipes_KosherTypesID");

            entity.HasIndex(e => e.SourceId, "FK_Recipes_SourceID");

            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.IngrediantId).HasColumnName("IngrediantID");
            entity.Property(e => e.KosherTypeId).HasColumnName("KosherTypeID");
            entity.Property(e => e.RecipeName).HasColumnType("text");
            entity.Property(e => e.SourceId).HasColumnName("SourceID");

            entity.HasOne(d => d.Ingrediant).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.IngrediantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipes_IngrediantsID");

            entity.HasOne(d => d.KosherType).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.KosherTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipes_KosherTypesID");

            entity.HasOne(d => d.Source).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipes_SourceID");
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeSources_SourceID");
        });

        modelBuilder.Entity<Recipesourcetype>(entity =>
        {
            entity.HasKey(e => e.SourceTypeId).HasName("PRIMARY");

            entity.ToTable("recipesourcetypes");

            entity.Property(e => e.SourceTypeId).HasColumnName("SourceTypeID");
            entity.Property(e => e.SourceTypeName).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
