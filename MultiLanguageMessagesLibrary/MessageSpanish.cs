using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLanguageMessagesLibrary {

    public class MessageSpanish : IMessage {

        public string GetByNumber(int nbr) {
            switch(nbr) {
                case 0: return "¡Todo está bien!";
                case 1: return "¡Es un gran dia!";
                case 2: return "Gracias.";
                default: return "¡Ese número no es válido!";
            }
        }
    }
}
