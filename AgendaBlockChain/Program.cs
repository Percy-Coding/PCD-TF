using System;

namespace AgendaBlockChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Block!");
            AgendaApp agendaApp = new AgendaApp();
            agendaApp.Start();
        }
    }
}
