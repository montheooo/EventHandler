using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    internal class Subcriber
    {
        public void OnPersonAgeOver20(object? sender, PersonEventArgs? args)
        {


            Console.WriteLine("Initiating transferring the data of the user to employee database");
            

        }
    }
}
