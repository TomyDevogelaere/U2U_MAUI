using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stravomondo.Data
{
    public class Activity
    {
        public Activity(int id, string title, double distance, double effort)
        {
            Id = id;
            Title = title;
            Distance = distance;
            Effort = effort;
        }
        
        public int Id { get; set; }
        public string Title { get; set; }
        public double Distance { get; set; }
        public double Effort { get; set; }
    }
}
