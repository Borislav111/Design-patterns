using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearIterator;

namespace YearFacts
{
    public interface IYear
    {
        void Add(string fact);

        IIterator CreateIterator();
    }
}
