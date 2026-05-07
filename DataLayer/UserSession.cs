using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class UserSession
    {
        public static string MaNV { get; set; }  
        public static string Role { get; set; } 
        public static string EFConnectionString { get; set; }
        public static bool IsLoggedIn => !string.IsNullOrEmpty(MaNV);

        public static void Clear()
        {
            MaNV = string.Empty;
            Role = string.Empty;
            EFConnectionString = string.Empty;
        }
    }
}
