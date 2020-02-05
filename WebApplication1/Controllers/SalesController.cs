using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using SnapObjects.Data;
using DWNet.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _isalesservice;

        public SalesController(ISalesService isalesservice)
        {
            _isalesservice = isalesservice;
        }		

		//GET api/Sales/RetrieveOne/{id}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(SalesModel), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<SalesModel> RetrieveOne(int id)
		{
			try
            {
				var result = _isalesservice.RetrieveOne(id);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//GET api/Sales/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IList<SalesModel>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<IList<SalesModel>> Retrieve()
		{
			try
            {
				var result = _isalesservice.Retrieve();
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/Sales/Create
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Create([FromBody]SalesModel salesmodel)
		{
			try
            {
				var result = _isalesservice.Create(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/Sales/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Update([FromBody]IModelEntry<SalesModel> salesmodel)
		{
			try
            {
				var result = _isalesservice.Update(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/Sales/Update1
		[HttpPost]
		[ActionName("Update1")]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Update([FromBody]SalesModel salesmodel)
		{
			try
            {
				var result = _isalesservice.Update(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//DELETE api/Sales/Delete/{id}
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Delete(int id)
		{
			try
            {
				var result = _isalesservice.Delete(id);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}
	
	}
}
