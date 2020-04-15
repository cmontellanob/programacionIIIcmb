using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    class Program2
    {
        static void Main(string[] args)
        {
            Person juan = new Person();
            juan.PurchaceParkingTicket();

            Professor carlos = new Professor();
            carlos.PurchaceParkingTicket();

            Student kasandra = new Student();
            kasandra.IsEligibaleToEnroll();

            kasandra.PurchaceParkingTicket();

            Address direccion = new Address();
            direccion.Validate();


        }
    }
}
