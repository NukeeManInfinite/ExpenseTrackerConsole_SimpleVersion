using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpenseTrackerConsoleAppSimple
{
    internal class Expense
    {

        public string Name
        {
            get;
            set;
        }
        public int Amount
        {
            get;
            set;
        }
        public TimeOnly Time
        {
            get;
            set;
        }
    }
}
