using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210125
{
    internal class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storeData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void addNewData(T store, DateTime det)
        {
            storeData.Add(store);
            inputDates.Add(det);
        }

        public void printData()
        {
            for (int i = 0; i < storeData.Count; i++){
                Console.WriteLine("Data " + (i + 1) + " berisi" + storeData[i] + "yang disimpan pada waktu" + inputDates[i]);
            }
        }
    }
}
