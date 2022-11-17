using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stravomondo.Data
{
    public static class DataSource
    {
        public static List<Activity> Activities { get; set; } = new List<Activity>()
        {
            new Activity(1, "Evening run", 5.6, 5),
            new Activity(2, "Morning run", 5.7, 6),
            new Activity(3, "Long run", 15.6, 10),
        };
    }
}
