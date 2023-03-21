using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gregSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService housesService;

        public HousesController(HousesService housesService)
        {
            this.housesService = housesService;
        }
        [HttpGet]
        public ActionResult<List<House>> Find()
        {
            try 
            {
            List<House> houses = housesService.Find();
            return houses;
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
    }
}