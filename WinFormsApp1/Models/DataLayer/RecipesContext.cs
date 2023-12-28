using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=C:\\MSSQL\\MSSQL16.SQLSERVER\\MSSQL\\DATA\\Recipes.mdf; Integrated security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingrediant>(entity =>
        {
            entity.HasKey(e => e.IngrediantName).HasName("PK__Ingredia__384EF443F3408EE7");

            entity.HasOne(d => d.IngrediantTypeNavigation).WithMany(p => p.Ingrediants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ingrediants_IngrediantTypes");
        });

        modelBuilder.Entity<IngrediantSubstitute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredia__3214EC27FA73BF82");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IngrediantSubstitutedByNavigation).WithMany(p => p.IngrediantSubstitutes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ingredian__Ingre__398D8EEE");
        });

        modelBuilder.Entity<IngrediantType>(entity =>
        {
            entity.HasKey(e => e.Type).HasName("PK__Ingredia__F9B8A48A3F82911C");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
