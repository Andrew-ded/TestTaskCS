using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Model;
using Repositorys;

namespace App
{
    public class SubdivisionsService: ISubdivisionsService
    {
        private readonly ISubdivisionsRepository subdivisionsRepository;
        private readonly IUserRepository userRepository;
        
        public SubdivisionsService(ISubdivisionsRepository subdivisionsRepository, IUserRepository userRepository)
        {
            this.subdivisionsRepository = subdivisionsRepository;
            this.userRepository = userRepository;
        }



        public async Task<List<Subdivision>> GetAllSubdivisions()
        {
            var _subvis = await subdivisionsRepository.GetAllSubdivisions();

     
            return _subvis;
        }

        public async Task<Subdivision?> GetSubdivisions(int id)
        {
            var _subvis = await subdivisionsRepository.GetSubdivisions(id);

            return _subvis;
        }
    }
}
