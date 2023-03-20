using modul5_1302210125;
using System.Runtime.InteropServices;

namespace modul5_1302210125
{
    class Mainprogram
    {
        static void Main(String[] args)
        {
            SimpleDataBase<double> PJ = new SimpleDataBase<double> ();
            PJ.addNewdata1(13, DateTime.Now);
            PJ.addNewdata2(13, DateTime.Now);
            PJ.addNewdata3(13, DateTime.Now);

            PJ.printAllData();
        }
    }
}