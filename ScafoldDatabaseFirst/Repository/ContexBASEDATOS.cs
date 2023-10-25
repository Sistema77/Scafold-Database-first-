using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ScafoldDatabaseFirst.Repository.Models;

namespace ScafoldDatabaseFirst.Repository;

public partial class ContexBASEDATOS : DbContext
{
    public ContexBASEDATOS()
    {
    }

    public ContexBASEDATOS(DbContextOptions<ContexBASEDATOS> options)
        : base(options)
    {
    }

    public virtual DbSet<GbpAlmCatLibro> GbpAlmCatLibros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=Admin;Database=gestorBibliotecaPersonal;searchpath=public");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GbpAlmCatLibro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("gbp_alm_cat_libros_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
