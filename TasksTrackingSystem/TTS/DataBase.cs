using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTS
{
    public class DataBase : DataBaseService<Worker>
    {
        public DataBase()
        {
            list = new List<Worker>();

            list.Add(new Worker());
            list.Add(new Worker());
            list.Add(new Worker());
            list.Add(new Worker());
            list.Add(new Worker());

            list[0].FirstName = "qwer";
            list[1].FirstName = "asdf";
            list[2].FirstName = "zxcv";
            list[3].FirstName = "wert";
            list[4].FirstName = "sdfg";
        }
    }
}
