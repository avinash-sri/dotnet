using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Company.Project.ProductDomain.Domain
{
    public partial class BookReadingEventsContext : DbContext
    {
        public BookReadingEventsContext()
        {
        }

        public BookReadingEventsContext(DbContextOptions<BookReadingEventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookReadingEvent> BookReadingEvent { get; set; }
        public virtual DbSet<CommentEvent> CommentEvent { get; set; }
        public virtual DbSet<InviteeEvent> InviteeEvent { get; set; }
        public virtual DbSet<LookUp> LookUp { get; set; }
        public virtual DbSet<LookUpCategory> LookUpCategory { get; set; }
        public virtual DbSet<UserRegistration> UserRegistration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=IN-5LLRXM3;Database=BookReadingEvents;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookReadingEvent>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DurationInHours).HasColumnName("Duration in hours");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OtherDetails).HasColumnName("Other Details");

                entity.Property(e => e.StartTime).HasColumnName("Start Time");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.StartTimeNavigation)
                    .WithMany(p => p.BookReadingEventStartTimeNavigation)
                    .HasForeignKey(d => d.StartTime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookReadingEvent_LookUp");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.BookReadingEventTypeNavigation)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookReadingEvent_LookUp1");
            });

            modelBuilder.Entity<CommentEvent>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(50);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.CommentEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentEvent_BookReadingEvent");
            });

            modelBuilder.Entity<InviteeEvent>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.InviteeEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InviteeEvent_BookReadingEvent");
            });

            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LookUpCategory)
                    .WithMany(p => p.LookUp)
                    .HasForeignKey(d => d.LookUpCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookUp_LookUpCategory");
            });

            modelBuilder.Entity<LookUpCategory>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRegistration>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserType).HasColumnName("User Type");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.UserRegistration)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRegistration_LookUp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
