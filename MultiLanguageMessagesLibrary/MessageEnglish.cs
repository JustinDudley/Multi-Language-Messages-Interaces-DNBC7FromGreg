using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLanguageMessagesLibrary {

    public class MessageEnglish : IMessage {

        public string GetByNumber(int nbr) {
            switch(nbr) {
                case 0: return "Everything is ok!";
                case 1: return "It is a great day!";
                case 2: return "Thank you.";
                default: return "That number is not valid!";
            }
        }
    }
}
