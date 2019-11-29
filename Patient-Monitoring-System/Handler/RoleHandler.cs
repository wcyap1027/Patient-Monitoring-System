using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System.Handler
{
    public class RoleHandler
    {
        public int addNewRole(MySqlConnection conn, Role role)
        {
            string sql = "INSERT into role( represent, position)" + "VALUES('" + role.Represent + "', '" + role.Position + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }


        public List<Role> getAllRole(MySqlConnection conn)
        {
            List<Role> listRoles = new List<Role>();
            string sql = "SELECT position FROM role";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    string position = (string)myReader.GetValue(0);
                    listRoles.Add(new Role(position));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listRoles;
        }
    }
}
