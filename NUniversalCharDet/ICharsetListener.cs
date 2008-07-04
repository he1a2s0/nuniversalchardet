using System;
using System.Collections.Generic;
using System.Text;

namespace Mozilla.NUniversalCharDet
{
    public interface ICharsetListener
    {
        void Report(string charset);
    }
}
