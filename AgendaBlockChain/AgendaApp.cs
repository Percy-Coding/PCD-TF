using AgendaBlockChain.Controllers;
using AgendaBlockChain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace AgendaBlockChain
{
    public class AgendaApp
    {
        public void CreateContact()
        {
            Contacto nuevoContacto = new Contacto();
            nuevoContacto.Name = "Percy";
            nuevoContacto.Number = "987149812";

            ContactoController contactoController = new ContactoController();
            contactoController.Create(nuevoContacto);
        }
        public void Start()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket server;
            IPEndPoint remoteEndpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8030);

            socket.Bind(remoteEndpoint);
            socket.Listen(10);

            server = socket.Accept();
            Console.WriteLine("Conextion on");

            byte[] receiveBuffer = new byte[256];
            string data;
            int arraySize = server.Receive(receiveBuffer,0,receiveBuffer.Length,0);
            Array.Resize(ref receiveBuffer, arraySize);
            data = Encoding.Default.GetString(receiveBuffer);

            Console.WriteLine("La info es: {0}", data);
            Console.ReadKey();
            socket.Close();
        }
    }
}
