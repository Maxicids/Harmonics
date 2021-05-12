using System;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;
using Harmonics.Repository;

namespace Harmonics.Models.UnitOfWork
{
    public sealed class UnitOfWork : IDisposable
    {
        private readonly MessengerModel messengerModel = new MessengerModel();
        private UserRepository userRepository;
        private ReportRepository reportRepository;
        private BlockedRepository blockedRepository;
        private ChatsRepository chatsRepository;
        private MessageRepository messageRepository;
        private RoleRepository roleRepository;
        public UserRepository Users => userRepository ?? (userRepository = new UserRepository(messengerModel));
        public ReportRepository Reports => reportRepository ?? (reportRepository = new ReportRepository(messengerModel));
        public BlockedRepository Blocked => blockedRepository ?? (blockedRepository = new BlockedRepository(messengerModel));
        public ChatsRepository Chats => chatsRepository ?? (chatsRepository = new ChatsRepository(messengerModel));
        public MessageRepository Messages => messageRepository ?? (messageRepository = new MessageRepository(messengerModel));
        public RoleRepository Roles => roleRepository ?? (roleRepository = new RoleRepository(messengerModel));
        
        public void Save()
        {
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