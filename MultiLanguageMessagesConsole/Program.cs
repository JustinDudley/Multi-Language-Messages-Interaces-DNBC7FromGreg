using MultiLanguageMessagesLibrary;
using System;

namespace MultiLanguageMessagesConsole {
    class Program {
        static void Main(string[] args) {

            var msgen = new MessageEnglish();
            var msgsp = new MessageSpanish();
            var msg = new Message(msgsp);
            for(var idx = 0; idx < 4; idx++)
                Console.WriteLine(msg.GetByNumber(idx));
        }
    }
}
