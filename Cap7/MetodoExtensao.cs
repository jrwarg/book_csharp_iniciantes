using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Cap7
{
        // o método de extensão DEVE ser static 
        static void Main(string[] args)
        {
            public static class MetodoExtensao
            {
            public static string FormatarData(this DateTime data, string formato) => data.ToString(formato);
             }
        }
    }
}