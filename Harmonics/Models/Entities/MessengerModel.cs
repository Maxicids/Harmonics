using System.Data.Entity;

namespace Harmonics.Models.Entities
{
    public partial class MessengerModel : DbContext
    {
        public MessengerModel()
            : base("name=MessengerConnection")
        {
        }

        public virtual DbSet<Blocked> Blockeds { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<ReportContent> ReportContents { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Chat>()
                .Property(e => e.mainPicture);

            modelBuilder.Entity<Chat>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.Chat)
                .HasForeignKey(e => e.chat_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chat>()
                .HasMany(e => e.Participants)
                .WithRequired(e => e.Chat1)
                .HasForeignKey(e => e.chat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportContent>()
                .HasMany(e => e.Blockeds)
                .WithOptional(e => e.ReportContent)
                .HasForeignKey(e => e.reason);

            modelBuilder.Entity<ReportContent>()
                .HasMany(e => e.Reports)
                .WithOptional(e => e.ReportContent)
                .HasForeignKey(e => e.reason);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role1)
                .HasForeignKey(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Setting>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Setting)
                .HasForeignKey(e => e.settings)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Blockeds)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.from_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Participants)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.participant1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reports)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.sender_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reports1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
