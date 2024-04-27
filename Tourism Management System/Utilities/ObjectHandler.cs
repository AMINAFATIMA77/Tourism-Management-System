using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_LIbrary.DL.DLwithDB;
using TMS_LIbrary.DLInterfaces;

namespace Tourism_Management_System.Utilities
{
    public class ObjectHandler
    {
        private static IHotel hotelDL = new HotelDl();
        //private static IHotel hotelDL = new HotelDlFH();
        private static IPerson PersonDL = new PersonDl();
        private static IPackage packageDL = new PackageDl();
        private static IMedicine MedicineDL = new MedicineDl();
        private static IFood FoodDL = new FoodDl();


        public static IHotel GetHotelDl()
        {
            return hotelDL;
        }

        public static IPerson GetPersonDL()
        {
            return PersonDL;
        }

        public static IPackage GetPackageDL()   
        {
            return packageDL;
        }

        public static IMedicine GetMedicineDL()
        {
            return MedicineDL;
        }

        public static IFood GetFoodDL()
        {
            return FoodDL;
        }
    }
}
