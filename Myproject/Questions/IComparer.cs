using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    interface IComparer <in Question>
    {
        int Compare(Question, Question);
    }
}
