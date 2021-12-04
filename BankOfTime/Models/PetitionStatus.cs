using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfTime.Models
{
    public class PetitionStatus
    {
        public enum status
        {
            pending = 1,
            onGoing = 2,
            finished = 3,
            canceled = 4
        }
    }
}
