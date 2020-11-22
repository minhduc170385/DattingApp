using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Data;
using API.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using AttributeRouting.Web.Http;
namespace API.Controllers
{
    //  [ApiController]
    //  [Router("api/[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

         [HttpGet]
         public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync();            
         }

         //api/users/3
          [HttpGet("{id}")]
          public async Task<ActionResult<AppUser>> GetUsers(int id){
              return await _context.Users.FindAsync(id);            
          }


    }
}