using System;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;
using Harmonics.Repository;

// ReSharper disable once CheckNamespace
namespace Harmonics.Models.UnitOfWork
{
    public sealed class UnitOfWork : IDisposable
    {
        private readonly MessengerModel messengerModel = new();
        private UserRepository userRepository;
        private ReportRepository reportRepository;
        private BlockedRepository blockedRepository;
        private ChatsRepository chatsRepository;
        private MessageRepository messageRepository;
        private RoleRepository roleRepository;
        private ParticipantRepository participantRepository;
        private ReportContentRepository reportContentRepository;
        private SettingsRepository settingsRepository;
        public UserRepository Users => userRepository ??= new UserRepository(messengerModel);
        public ReportRepository Reports => reportRepository ??= new ReportRepository(messengerModel);
        public BlockedRepository Blocked => blockedRepository ??= new BlockedRepository(messengerModel);
        public ChatsRepository Chats => chatsRepository ??= new ChatsRepository(messengerModel);
        public MessageRepository Messages => messageRepository ??= new MessageRepository(messengerModel);
        public RoleRepository Roles => roleRepository ??= new RoleRepository(messengerModel);
        public SettingsRepository Settings => settingsRepository ??= new SettingsRepository(messengerModel);
        public ParticipantRepository Participants => participantRepository ??= new ParticipantRepository(messengerModel);
        public ReportContentRepository ReportContents =>
            reportContentRepository ??= new ReportContentRepository(messengerModel);
        public void Save()
        {
            //messengerModel.SaveChangesAsync();
            messengerModel.SaveChanges();
        }
 
        private bool disposed;

        private void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                messengerModel.Dispose();
            }
            disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            // ReSharper disable GCSuppressFinalizeForTypeWithoutDestructor
            GC.SuppressFinalize(this);
        }
    }
}