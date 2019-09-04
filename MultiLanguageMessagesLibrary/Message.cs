using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLanguageMessagesLibrary {

    public interface IMessage {
        string GetByNumber(int nbr);
    }
    public class Message {

        IMessage message;

        public string GetByNumber(int nbr) {
            return message.GetByNumber(nbr);
        }

        public Message(IMessage message) {
            this.message = message;
        }
    }
}
