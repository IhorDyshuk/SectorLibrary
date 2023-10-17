using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectorLibrary
{
    public interface ISector
    {
        double Radius { get; set; }
        double Angle { get; set; }
        string ToString();
    }
}
