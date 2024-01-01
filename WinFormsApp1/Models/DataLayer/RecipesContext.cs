using System;
using System.Collections.Generic;
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

    public virtual DbSet<IngrediantSubstitute> IngrediantSubstitutes { get; set; }

    public virtual DbSet<IngrediantType> IngrediantTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\MSSQL\\MSSQL16.SQLSERVER\\MSSQL\\DATA\\Recipes.mdf; Integrated security=True;");

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
            entity.HasKey(e => e.SubstitutedById).HasName("PK__Ingredia__E74B6A2C9ABA3C95");

            entity.HasOne(d => d.IngrediantName).WithMany(p => p.IngrediantSubstituteIngrediantNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngrediantSubstitute_IngrediantNameID");

            entity.HasOne(d => d.IngrediantSubstitutedBy).WithMany(p => p.IngrediantSubstituteIngrediantSubstitutedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngrediantSubstitute_IngrediantSubstitutedByID");
        });

        modelBuilder.Entity<IngrediantType>(entity =>
        {
            entity.HasKey(e => e.IngrediantTypeId).HasName("PK__Ingredia__7B74DA47B63AF65D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
