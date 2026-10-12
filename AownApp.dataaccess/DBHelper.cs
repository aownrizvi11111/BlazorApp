using Npgsql;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace AownApp.dataaccess
{
    public class DBHelper
    {
        public static NpgsqlConnection GetConnection() {

            return new NpgsqlConnection("Host = aws - 0 - ap - northeast - 1.pooler.supabase.com; Port = 6543; Database = postgres; Username = postgres.ivqgofrxmamzjbhnvfcx; Password = Aown1@1.com; SSL Mode = Require; Trust Server Certificate = true");
        
        }

    }
}
