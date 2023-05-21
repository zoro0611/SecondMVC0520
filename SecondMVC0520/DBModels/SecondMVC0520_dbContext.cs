using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecondMVC0520.DBModels
{
    public partial class SecondMVC0520_dbContext : DbContext
    {
        public SecondMVC0520_dbContext()
        {
        }

        public SecondMVC0520_dbContext(DbContextOptions<SecondMVC0520_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookInfo> BookInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=secondmvc0520dbserver.database.windows.net;Initial Catalog=SecondMVC0520_db;User id=zoro0611;Password=A127753029x;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookInfo>(entity =>
            {
                entity.ToTable("BookInfo");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
