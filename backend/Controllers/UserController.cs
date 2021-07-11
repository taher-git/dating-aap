using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext context;
        public UserController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){
            return await context.Users.FindAsync(id);
        }
    }
}