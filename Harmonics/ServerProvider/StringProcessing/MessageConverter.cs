using System.Text;

namespace Harmonics.Models.ServerProvider.StringProcessing
{
    public static class MessageConverter
    {
        public static byte[] ConvertMessage(MessageType messageType, string message)
        {
            switch (messageType)
            {
                case MessageType.LogInMessage:
                    return ConvertToLogInMessage(message);
                case MessageType.RegisterMessage:
                    return ConvertToRegisterMessage(message);
                case MessageType.ChatMessage:
                    return ConvertToChatMessage(message);
                case MessageType.DeleteUser:
                    return ConvertToDeleteUserMessage(message);
                case MessageType.SaveSettings:
                    return ConvertToSaveSettingsMessage(message);
                case MessageType.CreateChat:
                    return ConvertToCreateChatMessage(message);
                default:
                    return null;
            }
        }
        private static byte[] ConvertToLogInMessage(string message)
        {
            //TODO: Validation
            message = message.Insert(0, "10");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
        private static byte[] ConvertToRegisterMessage(string message)
        {
            message = message.Insert(0, "11");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
        private static byte[] ConvertToChatMessage(string message)
        {
            message = message.Insert(0, "12");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
        private static byte[] ConvertToDeleteUserMessage(string message)
        {
            message = message.Insert(0, "13");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
        private static byte[] ConvertToCreateChatMessage(string message)
        {
            message = message.Insert(0, "14");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
        private static byte[] ConvertToSaveSettingsMessage(string message)
        {
            message = message.Insert(0, "15");
            message = message.Insert(2, ";");
            return Encoding.UTF8.GetBytes(message);
        }
    }
}