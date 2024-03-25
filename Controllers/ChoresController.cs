
using Microsoft.AspNetCore.Http.HttpResults;

namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase 
{
  private readonly ChoresService _choresService; 

  public ChoresController(ChoresController _choresService)
  {
    _choresService = _choresService; 
  }

  [HttpGet("test")]
  public ActionResult<string> TestApi()
  {
    try
    {
      return Ok("LOCKED AND LOADED, BABY!! The Api is up and running");
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet] 
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetChores();
      return Ok(chores);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.CreateChore(choreData);
      return Ok(chore)
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

}