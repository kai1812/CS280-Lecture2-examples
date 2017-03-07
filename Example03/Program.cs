using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
                @ "select * from table where id >1000" ;
            string xml =
                @"<Pokemon>
                      <NationalNo>#001</NationalNo>
                      <Name>Bulbstaur</Name>
                  </Pokemon>" ;
            string json =
                @"Pokemaon ={
                      NationalNo: "#001"
        }
    }
}