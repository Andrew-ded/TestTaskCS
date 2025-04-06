using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Domain;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ISubdivisionsService _serviceData;

        public ValuesController(ISubdivisionsService serviceData)
        {
            _serviceData = serviceData;
        }

        [HttpGet]
        [Route("index")]
        public async Task<List<Subdivision>> Index()
        {
            var i = await _serviceData.GetAllSubdivisions();
            return i;
        }

        [HttpGet]
        [Route("getCount")]
        public async Task<int> GetCount(int id)
        {
            var i = await _serviceData.GetSubdivisions(id);

            return Func.CountEmployees(i);
        }
    }
}
