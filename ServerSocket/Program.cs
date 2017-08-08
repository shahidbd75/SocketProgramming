using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int reqCount = 0;
            TcpListener tcpListener=new TcpListener(IPAddress.Loopback,8888);

            tcpListener.Start();
            
            Console.WriteLine("Socket Server Started.......");

            TcpClient client = tcpListener.AcceptTcpClient();
            Console.WriteLine("Accepting Connection...");
            bool isContinue = true;
            while (isContinue)
            {
                try
                {
                    reqCount += 1;
                    // Receive Data From Client
                    NetworkStream stream = client.GetStream();
                    byte[] getByteData = new byte[1024 * 1024];
                    stream.Read(getByteData, 0, client.ReceiveBufferSize);
                    string stringData = Encoding.ASCII.GetString(getByteData);
                    string receiveString = stringData.Substring(0, stringData.IndexOf('$'));
                    Console.WriteLine("Data From Client>> " + receiveString);
                    stream.Flush();

                    // Send Data to Client
                    string sendData = "Last Data Receive From Client: " + receiveString;

                    byte[] sendByte = Encoding.ASCII.GetBytes(sendData);
                    stream.Write(sendByte, 0, sendByte.Length);
                    stream.Flush();
                    Console.WriteLine(">>" + sendData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isContinue = false;
                }
            }

            client.Close();
            tcpListener.Stop();
            Console.WriteLine("End and Exit");
            Console.ReadLine();
        }
    }
}
