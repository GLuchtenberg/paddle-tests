using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
// using Qualyteam.Api.Web;
// using Qualyteam.Doc.Domain.Entity;
// using Qualyteam.Doc.Application.CommandSide.Mutations;
// using Qualyteam.Doc.Application.Services;

namespace Qualyteam.Doc.Api.Controllers
{
    [Route("api/gateway/webhook")]
    [Authorize]
    public class WebhookController : Controller
    {
        // private readonly ICategoryService _service;
        // private readonly CrudController<Category, int> _controller;

        // public WebhookController(ICategoryService service)
        // {
        //     _controller = new CrudController<Category, int>(this, service);
        //     _service = service;
        // }

        [HttpPost]
        public async Task<IActionResult> Payment()
        {
            return Ok("Hello Worlde!");
        }

        // [HttpGet("{id:int}")]
        // public IActionResult Find(int id)
        // {
        //     var category = _service.FindForm(id);
        //     if (category == null)
        //         return NotFound();

        //     return Ok(category);
        // }


        // [HttpGet("{categoryId:int}/stages")]
        // public IActionResult ListStages(int categoryId)
        // {
        //     return Ok(_service.ListStages(categoryId));
        // }

        // [HttpPost]
        // public async Task<IActionResult> Insert([FromBody] UpdateCategoryMutation category)
        // {
        //     if (category == null)
        //         return BadRequest();

        //     return Ok(await _service.Insert(category));
        // }

        // [HttpPut("{id:int}")]
        // public async Task<IActionResult> Update(int id, [FromBody] UpdateCategoryMutation category)
        // {
        //     if (category == null)
        //         return BadRequest();

        //     return Ok(await _service.Update(id, category));
        // }

        // [HttpDelete("{id:int}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     var category = await _service.Delete(id);
        //     return Ok(category);
        // }
    }
}