using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Domain.Interface
{
    public interface ISubdivisionsRepository
    {
        public Task<List<Subdivision>> GetAllSubdivisions();

        public Task<Subdivision> GetSubdivisions(int id);

        public Task<Subdivision> CreateSubdivisions(Subdivision sub);
    }
}
