using Microsoft.AspNetCore.Mvc;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        [HttpGet]
        [Route("post")]
        public async Task<ActionResult<IEnumerable<SupplierPost>>> GetPost()
        {
            var data = await supplierRepository.GetAllPost();
            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<SupplierPost>>> GetPostsById(string Id)
        {
            var data = await supplierRepository.GetAllPostById(Id);
            return Ok(data);
        }

        [Route("newpost")]
        [HttpPost]
        public  ActionResult AddNewPost([FromBody] SupplierPost supplierPost)
        {
            try
            {

                var newPost = new SupplierPost
                {
                    title = supplierPost.title,
                    UserId = supplierPost.UserId,
                    Description = supplierPost.Description,
                    Image = supplierPost.Image,
                    City = supplierPost.City,
                    Price = supplierPost.Price,
                    Phone = supplierPost.Phone

                };
                 supplierRepository.Add(newPost);

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok();
        }
    }
}
