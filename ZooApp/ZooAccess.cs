using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class ZooAccess
    {
        private DataAccessZoo _dataAccessZoo;

        public ZooAccess()
        {

            _dataAccessZoo = new DataAccessZoo();

        }
        public AnimalS SaveAnimal(AnimalS Addanimal)
        {
            if (Addanimal.Nombre != null)
            
                _dataAccessZoo.InsertAnimal(Addanimal);

                return Addanimal;

            
           // else
               // _dataAccessZoo.UpdateAnimal;
        }

    }
}
