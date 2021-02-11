using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Net;

namespace MonoTestInput
{
    public class ClientHandle
    {
        //Client Receiving Information from Server

        public static void Welcome(Packet _packet)
        {

            string _msg = _packet.ReadString();
            int _myId = _packet.ReadInt();

            Console.WriteLine($"Message from server: {_msg}");
            UserClient.instance.myId = _myId;
            ClientSend.WelcomeReceived();

            UserClient.instance.udp.Connect(((IPEndPoint)UserClient.instance.tcp.socket.Client.LocalEndPoint).Port);
        }

    }
}
