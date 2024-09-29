using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class GetActivityData : BaseApiController
{
    public GetActivityData(DataContex dataContex) : base(dataContex)
    {
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Activity>>> GetAllActivities() 
        => await _dataContext.Activities.ToListAsync();

    [HttpGet("GetById/{ird}")]
    public async Task<ActionResult<Activity>> GetActivityById(Guid ird)
        => await _dataContext.Activities.SingleOrDefaultAsync(x => x.Id == ird);
}