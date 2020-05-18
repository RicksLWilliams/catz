using System;
using System.Collections.Generic;
using catz.DB;
using Microsoft.AspNetCore.Mvc;

namespace catz
{

  [ApiController]
  [Route("api/[controller]")]
  public class CatsController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Cat>> GetAll()
    {
      try
      {
        return Ok(FakeDB.Cats);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpGet("{Id}")]
    public ActionResult<Cat> GetOne(string Id)
    {
      try
      {
        Cat foundCat = FakeDB.Cats.Find(c => c.Id == Id);
        if (foundCat == null)
        {
          throw new Exception("Invalid Id");
        }
        return Ok(foundCat);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    // [HttpGet("{burgerId}/ingredients")]
    // public ActionResult<Burger> GetIngredients(string burgerId)
    // {

    // }

    [HttpPost]
    public ActionResult<Cat> Create([FromBody] Cat newCat)
    {
      try
      {
        FakeDB.Cats.Add(newCat);
        return Created($"api/cats/{newCat.Id}", newCat);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Cat> Edit(string id, [FromBody] Cat updatedCat)
    {
      try
      {
        Cat catToUpdate = FakeDB.Cats.Find(b => b.Id == id);
        if (catToUpdate == null)
        {
          throw new Exception("Invalid Id");
        }
        //NOTE if this was not required
        catToUpdate.Name = updatedCat.Name == null ? catToUpdate.Name : updatedCat.Name;
        catToUpdate.Owner = updatedCat.Owner;
        catToUpdate.Breed = updatedCat.Breed;
        return Ok(catToUpdate);
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(string id)
    {
      try
      {
        Cat catToDelete = FakeDB.Cats.Find(b => b.Id == id);
        if (catToDelete == null)
        {
          throw new Exception("Invalid Id");
        }
        FakeDB.Cats.Remove(catToDelete);
        return Ok("Deleted");
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }



  }


}