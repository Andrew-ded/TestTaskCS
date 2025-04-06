using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Domain.ViewModels
{
    public class IndexView
    {
        public IndexView(List<Subdivision> subdivisions)
        {
            Subdivisions = subdivisions;
        }

        public List<Subdivision> Subdivisions { get; set; } = new();




    }
}
