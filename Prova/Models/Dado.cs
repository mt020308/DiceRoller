using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Models
{
    public class Dado
    {
        public int NumLados { get; set; }

        public int NumSort { get; set; }
        

        public void RolarDado()
        {
            NumSort = new Random().Next(NumLados) + 1;
        }

        public Dado(int num)
        {
            NumLados = num;
        }
    }
}
