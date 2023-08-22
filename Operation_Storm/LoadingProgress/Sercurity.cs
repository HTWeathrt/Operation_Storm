using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;
using System.Net;
using Operation_Storm.SQL;

namespace Operation_Storm.LoadingProgress
{
    internal class Sercurity
    {
        public void User_Login(string User , string Password , string Foder_Open , string Line)
        {
            NetworkCredential credentials = new NetworkCredential(User, Password);

            string filePath = Foder_Open; // Đường dẫn tới tệp chia sẻ
            try
            {
                using (new NetworkConnection(filePath, credentials))
                {
                    // Đọc nội dung tệp chia sẻ
                    SQLUpdate update = new SQLUpdate();
                    update.SQL_connector("Connection", "Test", "Null", "00", "00", Line, "VH009213");
                }
            }
            catch (Exception ex)
            {
                
            }

        }
        private static SecureString GetSecureString()
        {
            SecureString secureString = new SecureString();
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                secureString.AppendChar(keyInfo.KeyChar);
            }
            return secureString;
        }
        public class NetworkConnection : IDisposable
        {
            string _networkName;

            public NetworkConnection(string networkName, NetworkCredential credentials)
            {
                _networkName = networkName;

                var netResource = new NetResource
                {
                    Scope = ResourceScope.GlobalNetwork,
                    ResourceType = ResourceType.Disk,
                    DisplayType = ResourceDisplaytype.Share,
                    RemoteName = networkName
                };

                var result = WNetAddConnection2(netResource, credentials.Password, credentials.UserName, 0);

                if (result != 0)
                {
                    throw new IOException("Error connection" + result);
                }
            }

            ~NetworkConnection()
            {
                Dispose(false);
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                WNetCancelConnection2(_networkName, 0, true);
            }

            [System.Runtime.InteropServices.DllImport("mpr.dll")]
            private static extern int WNetAddConnection2(NetResource netResource, string password, string username, int flags);

            [System.Runtime.InteropServices.DllImport("mpr.dll")]
            private static extern int WNetCancelConnection2(string name, int flags, bool force);
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public class NetResource
        {
            public ResourceScope Scope;
            public ResourceType ResourceType;
            public ResourceDisplaytype DisplayType;
            public int Usage;
            public string LocalName;
            public string RemoteName;
            public string Comment;
            public string Provider;
        }

        public enum ResourceScope : int
        {
            Connected = 1,
            GlobalNetwork,
            Remembered,
            Recent,
            Context
        };

        public enum ResourceType : int
        {
            Any = 0,
            Disk = 1,
            Print = 2,
            Reserved = 8,
        }

        public enum ResourceDisplaytype : int
        {
            Generic = 0x0,
            Domain = 0x01,
            Server = 0x02,
            Share = 0x03,
            File = 0x04,
            Group = 0x05,
            Network = 0x06,
            Root = 0x07,
            Shareadmin = 0x08,
            Directory = 0x09,
            Tree = 0x0a,
            Ndscontainer = 0x0b
        }
    }


}

