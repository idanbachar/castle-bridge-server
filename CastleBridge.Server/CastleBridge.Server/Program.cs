﻿using System;
using System.Net;
using System.Net.Sockets;

namespace CastleBridge.Server {
    class Program {
        static void Main(string[] args) {

            Server server = new Server(4441);
            server.Start();





        }
    }
}