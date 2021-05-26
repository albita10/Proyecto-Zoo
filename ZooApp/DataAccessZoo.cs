using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZooApp
{
    class DataAccessZoo
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-73R9G8J;Initial Catalog=zooApp;Integrated Security=True");

        public void InsertAnimal(AnimalS Addanimal)
        {
            try
            {
                con.Open();
                string query = @"
                  INSERT INTO animal (Nombre,colorOjos,colorPiel,ubiPsVist,tipoAnimal,maneraRepro) VALUES (@Nombre,@colorOjos,@colorPiel,@ubiPsVist,@tipoAnimal,@maneraRepro)";

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.Value = Addanimal.Nombre;
                Nombre.DbType = System.Data.DbType.String;

                SqlParameter Ojos = new SqlParameter("@colorOjos", Addanimal.ColoOjos);
                SqlParameter Piel = new SqlParameter("@colorPiel", Addanimal.ColorPiel);
                SqlParameter Visto = new SqlParameter("@ubiPsVist", Addanimal.Visto);
                SqlParameter Tipo = new SqlParameter("@tipoAnimal", Addanimal.Tipo);
                SqlParameter Repro = new SqlParameter("@maneraRepro", Addanimal.Repro);

                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.Add(Nombre);
                cmd.Parameters.Add(Ojos);
                cmd.Parameters.Add(Piel);
                cmd.Parameters.Add(Visto);
                cmd.Parameters.Add(Tipo);
                cmd.Parameters.Add(Repro);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar"+ ex);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
