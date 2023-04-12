using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TemplateCVWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<Curriculum>> getCurriculum()
        {
            return new Curriculum
            {
                new Curriculum{Name = "Albert", LastName ="Pastor Martínez", PhoneNumber="669865675" }
            }
        }
    }
}
