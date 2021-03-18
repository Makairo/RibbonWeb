using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RibbonWeb.Models
{
    public class Repository
    {
        private static List<UserLog> logs = new List<UserLog>();

        public static IEnumerable<UserLog> Logs => logs;

        public static void AddLog(UserLog userLog)
        {
            logs.Add(userLog);
        }
    }
}
