using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AnEchoClientOPG
{
    class Client
    {

        //Create a class 'Client' and create a method 'Start'.
        public void Start()
        {
            String sendstr = "natascha jakobsen";

            //Create a TcpClient with the parameter IP = IPAddress.Loopback and PORT = 7070 and name it 'socket'.
            using (TcpClient socket = new TcpClient("localhost", 7070))
            using (NetworkStream ns = socket.GetStream()) //From the TcpClient 'GetStream()' and name it 'ns'.
            using (StreamReader sr = new StreamReader(ns)) //Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
            using (StreamWriter sw = new StreamWriter(ns)) //Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
            {
                string readingline = Console.ReadLine(); //Read a line from the console

                //Write the line to your stream-writer -- then remember to 'Flush()' the stream-writer.
                sw.WriteLine(sendstr);
                sw.Flush();

                //Read a line from your stream-reader ('ReadLine()') save it in a String and name it 'line'.
                String line = sr.ReadLine();

                //Print out the line in the console window('Console.WriteLine(line)).
                Console.WriteLine("Svar: " + line); 
            }


         }

    }
}
