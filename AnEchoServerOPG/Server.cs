using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AnEchoServerOPG
{
    class Server
    {
        public void Start()
        {
            //Create a TcpListener with the parameter IP = IPAddress.Loopback and PORT = 7070 .
            TcpListener server = new TcpListener(IPAddress.Loopback, 7070);

            //Server Start
            server.Start();


            //Open for incomming socket and for reading and writing-- All these should be in an using-statement
            //(This gives you the benefit of indirrect closing all sockets and streams in the using-st
            using (TcpClient socket = server.AcceptTcpClient())  //On the TcpListener 'AcceptTcpClient()' and name it 'socket'
            using (NetworkStream ns = socket.GetStream()) //From the TcpClient 'GetStream()' and name it 'ns'.
            using (StreamReader sr = new StreamReader(ns)) //Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
            using (StreamWriter sw = new StreamWriter(ns)) //Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
            {
                // Read a line from your stream-reader('ReadLine()') save it in a String and name it 'line' and print it on teh screen (Console).
                String line = sr.ReadLine();
                sw.WriteLine(line);

                //Read a line from the console (Console.ReadLine()) save it in a string(e.g. 'myLine')
                string myLine = Console.ReadLine();

                //Write back the 'myLine' to your stream - writer('WriteLine(line)')-- then remember to 'Flush()' the stream - writer.
                sw.WriteLine(myLine);
                sw.Flush();
            }
        }
    }
}
