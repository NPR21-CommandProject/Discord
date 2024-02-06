using DiscordWinForm.NetworkManagers;

namespace DiscordWinForm.StartupManagers
{
    public static class NetworkStartupManager
    {
        public static void StartNetworkCommunication()
        {
            StartListen();
            ConnectToServer();
        }

        private static void ConnectToServer() => 
            TcpManager.SendNewClientRequest();

        private static void StartListen() => TcpManager.StartListenThread();
    }
}
