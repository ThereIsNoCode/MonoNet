﻿using System;
using System.Collections.Generic;
using System.Text;
using MonoNet.Packets;

namespace MonoNet.Server
{
    class ServerHandle
    {
        public static Server server = new Server();

        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {

            int _clientIdCheck = _packet.ReadInt();
            //string _username = _packet.ReadString();



            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}.");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player \"\" (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
            }

        }
    }
}
