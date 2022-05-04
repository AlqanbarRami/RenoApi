using Microsoft.AspNetCore.Mvc;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Controllers
{
    [Route("api/construction")]
    [ApiController]
    public class ConstructionConroller : Controller
    {
        private readonly IConstructionRepository constructionRepository;

        public ConstructionConroller(IConstructionRepository constructionRepository)
        {
            this.constructionRepository = constructionRepository;
        }

        [HttpGet]
        [Route("post")]
        public async Task<ActionResult<IEnumerable<ConstructionPost>>> GetPost()
        {
            var data = await constructionRepository.GetAllPost();
            return Ok(data);
        }

        [Route("newpost")]
        [HttpPost]
        public ActionResult AddNewPost([FromBody] ConstructionPost constructionPost)
        {
            try
            {

                var newPost = new ConstructionPost
                {
                    title = constructionPost.title,
                    Description = constructionPost.Description,
                    Image = constructionPost.Image,
                    Phone = constructionPost.Phone
                };

                constructionRepository.Add(newPost);

             }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok();
        }



    }
       
    }
