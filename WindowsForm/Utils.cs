using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    public class Utils
    {
        public int CalculateProgress(int current_progress)
        {
            current_progress = current_progress < 0 ? 0 : current_progress; // cut negative  numbers
            return current_progress == 10 ? 0 : ++current_progress; // culculate progress
        }
    }
}
