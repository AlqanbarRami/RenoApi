using Microsoft.AspNetCore.Mvc;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
            private readonly ICustomerRepository customerRepository;

            public CustomerController(ICustomerRepository customerRepository)
            {
                this.customerRepository = customerRepository;
            }

            [HttpGet]
            [Route("post")]
            public async Task<ActionResult<IEnumerable<CustomerPost>>> GetPost()
            {
                var data = await customerRepository.GetAllPost();
                return Ok(data);
            }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<CustomerPost>>> GetPostsById(string Id)
        {   
            var data = await customerRepository.GetAllPostById(Id);
            return Ok(data);
        }
        [Route("newpost")]
        [HttpPost]
        public ActionResult AddNewPost([FromBody] CustomerPost customerPost)
        {
            try
            {

                var newPost = new CustomerPost
                {
                     Title = customerPost.Title,
                     UserId = customerPost.UserId,
                     Description = customerPost.Description,
                     City = customerPost.City,
                     Image = customerPost.Image,
                     PhoneNumber = customerPost.PhoneNumber

    };
                customerRepository.Add(customerPost);

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok();
        }

    }
}
