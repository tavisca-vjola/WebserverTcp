using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Webserver_using_tcp
{
    class Server
    {
            private TcpListener Listener;
            private int port = 8080;
            public Server()
            {
                    try
                    {
                             Listener = new TcpListener(port);
                             Listener.Start();
                             Console.WriteLine("Running Server");
                             Thread th = new Thread(StartListen);
                             th.Start();

                    }
                    catch(Exception e)
                    {
                             Console.WriteLine(e.ToString());
                    }
            }

        
    }
}
    
