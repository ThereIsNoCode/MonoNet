using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestInput
{
    class ClientSend
    {
        private static void SendTCPData(Packet _packet)
        {
            _packet.WriteLength();
            UserClient.instance.tcp.SendData(_packet);
        }

        private static void SendUDPData(Packet _packet)
        {
            _packet.WriteLength();
            UserClient.instance.udp.SendData(_packet);
        }

        #region Packets

        public static void WelcomeReceived()
        {
            using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
            {
                Console.WriteLine("Sending To Server");
                _packet.Write(UserClient.instance.myId);
                SendTCPData(_packet);
            }
        }    

        #endregion
    }
}
