using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Model;
using Storage;

namespace Repositorys
{
    public class SubdivisionsRepository : ISubdivisionsRepository
    {
        private readonly TestTaskContext _context;

        public SubdivisionsRepository(TestTaskContext context) {
            _context = context;
        }

        public async Task<List<Subdivision>> GetAllSubdivisions()
        {
            var SubdivisionsEntities = await _context.Subdivisions
                .Include(u => u.Users)
                .ToListAsync();

            return SubdivisionsEntities;
        }

        public async Task<Subdivision> GetSubdivisions(int id)
        {
            var subdivisionsEntities = await _context.Subdivisions
                .Include(u => u.Users)
                .ToListAsync();
            var subdivision = subdivisionsEntities
            .First(b => b.Id == id);

            return subdivision;
        }


        public async Task<Subdivision> CreateSubdivisions(Subdivision sub)
        {
            var subdivision = new Subdivision(
                sub.Id,
                sub.Name,
                sub.Id);
           
            return subdivision;
        }

    }
}
