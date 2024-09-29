using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseApiController : ControllerBase
    {
        public DataContex _dataContext { get; }
        public BaseApiController(DataContex dataContex)
        {
            _dataContext = dataContex;
        }
    }
}
