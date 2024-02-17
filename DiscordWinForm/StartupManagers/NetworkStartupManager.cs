using DiscordWinForm.NetworkManagers;

namespace DiscordWinForm.StartupManagers
{
    public static class NetworkStartupManager
    {
        /// <summary>
        /// Send connection request to server.
        /// Start listening thread on client pc
        /// </summary>
        public static void StartNetworkCommunication()
        {
            SendConnectionRequestToServer();
            StartListen();
        }

        private static void SendConnectionRequestToServer() => 
            TcpManager.SendNewClientRequest();
        private static void StartListen() => 
            TcpManager.InitTcpListener();
    }
}
