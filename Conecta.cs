using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrabalhoComHeranca
{
        class Conexao
        {
        
            private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\programas\\TrabalhoComHeranca\\TrabalhoComHeranca\\Juliano.mdf;Integrated Security=True";
            private static SqlConnection con = null;
            public static SqlConnection ConectaAberto()
            {
                con = new SqlConnection(str);
            if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                try
                {
                    con.Open();
                }
                catch (SqlException sqle)
                {
                    con = null;
                }
                return con;
            }
            public static void ConectaFechado()
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
}
