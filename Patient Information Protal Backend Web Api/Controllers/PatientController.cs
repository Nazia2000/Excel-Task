using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Information_Protal_Backend_Web_Api.Models.Data;
using Patient_Information_Protal_Backend_Web_Api.Models.DBEntity;
using Patient_Information_Protal_Backend_Web_Api.Repositories;

namespace Patient_Information_Protal_Backend_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        
        public PatientController(ApplicationDbContext db)
        {
            this.db = db;
           
           
        }

        [HttpGet("all")]
        public ActionResult GetAll()
        {
            try
            {
                var data = new GenericRepository(db).GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var data = new GenericRepository(db).GetById(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("add")]
        public ActionResult Add([FromBody] Patient patient)
        {
            try
            {
                new GenericRepository(db).Add(patient);
                return Ok("Patient has been added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update")]
        public ActionResult Update(int id,Patient patient)
        {
            try
            {
                var data = new GenericRepository(db).Update(id,patient);
                if (data)
                {

                    return Ok("User Update");
                }
                else
                {
                    return BadRequest("Invalid data");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var data = new GenericRepository(db).Delete(id);
                if (data)
                {
                    return Ok(new { Success = "true", Message = "User Delete", Payload = data });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}
