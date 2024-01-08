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

    /*public RecipesContext(DbContextOptions options) : base(options)
    {
    }*/

    public virtual DbSet<Ingrediant> Ingrediants { get; set; }

    public virtual DbSet<IngrediantSubstitute> IngrediantSubstitutes { get; set; }

    public virtual DbSet<IngrediantType> IngrediantTypes { get; set; }

    public virtual DbSet<RecipeSource> RecipeSources { get; set; }

    public virtual DbSet<RecipeSourceType> RecipeSourceTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\MSSQL\\MSSQL16.SQLSERVER\\MSSQL\\DATA\\Recipes.mdf; Integrated security=True");*/
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Recipes"].ConnectionString,
            providerOptions => providerOptions.EnableRetryOnFailure());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingrediant>(entity =>
        {
            entity.HasKey(e => e.IngrediantId).HasName("PK__Ingredia__BF28567CF8D60C3E");

            entity.HasOne(d => d.IngrediantType).WithMany(p => p.Ingrediants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingrediants_IngrediantsID");
        });

        modelBuilder.Entity<IngrediantSubstitute>(entity =>
        {
            entity.HasKey(e => e.SubstitutedById).HasName("PK__Ingredia__E74B6A2C127969C7");

            entity.HasOne(d => d.IngrediantName).WithMany(p => p.IngrediantSubstitutes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngrediantSubstitute_IngrediantNameID");
        });

        modelBuilder.Entity<IngrediantType>(entity =>
        {
            entity.HasKey(e => e.IngrediantTypeId).HasName("PK__Ingredia__7B74DA47B63AF65D");
        });

        modelBuilder.Entity<RecipeSource>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PK__RecipeSo__16E019F9333480E6");

            entity.HasOne(d => d.SourceTypeName).WithMany(p => p.RecipeSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeSources_SourceID");
        });

        modelBuilder.Entity<RecipeSourceType>(entity =>
        {
            entity.HasKey(e => e.SourceTypeId).HasName("PK__RecipeSo__7E17ECCFBDCAAAF7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
