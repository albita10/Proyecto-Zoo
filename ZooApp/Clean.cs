using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    class Clean
    {
        public void Limpiar(Control controltxt)
        {
            foreach (var txt in controltxt.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                    
                }

            }
        }
    }
}
