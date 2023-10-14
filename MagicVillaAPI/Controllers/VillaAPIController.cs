using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVillaAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController  ]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
    }
}
