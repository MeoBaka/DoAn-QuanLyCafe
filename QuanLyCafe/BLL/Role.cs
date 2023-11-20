using QuanLyCafe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.BLL
{
    internal class Role
    {
        
        public int CheckRole(TaiKhoan tk,string users , string role)
        {
            string sql = "SELECT COUNT(*) FROM M3_ACCOUNT WHERE ((USERS = @user) AND (CAST(ROLE AS NVARCHAR(100)) = @role))";
            string[] param = { "@user", "@role" };
            object[] value = { users, role };
            Console.WriteLine(users);
            Console.WriteLine(role);
            return tk.TaiKhoanExecuteScalar(sql, param, value);
        }

        
    }
}
