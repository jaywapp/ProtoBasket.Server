using Microsoft.AspNetCore.Mvc;
using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Repository;
using System.Collections.Generic;

namespace ProtoBasket.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtoController : ControllerBase
    {
        private ProtoRepository _protoRepo;

        public ProtoController()
        {
            _protoRepo = Startup.ProtoRepository;
        }

        [HttpGet]
        public IEnumerable<Proto> Get() => _protoRepo.Protos;

        [HttpGet("{id}")]
        public Proto Get(int id) => _protoRepo[id];
    }
}
