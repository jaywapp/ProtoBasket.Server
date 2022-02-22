using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProtoBasket.Common.Model;
using ProtoBasket.Common.Model.Repository;

namespace ProtoBasket.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private ProtoRepository _protoRepo;

        public MatchController()
        {
            _protoRepo = Startup.ProtoRepository;
        }

        [HttpGet]
        public IEnumerable<Match> Get()
        {
            return _protoRepo.Protos
                .SelectMany(p => p.Matches)
                .ToList();
        }

        [HttpGet("{id}")]
        public Match Get(int id)
        {
            var protoId = id / 100;
            var proto = _protoRepo[protoId];

            return proto[id];
        }
    }
}
