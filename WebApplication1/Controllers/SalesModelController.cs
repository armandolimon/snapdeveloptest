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
    public class SalesModelController : ControllerBase
    {
        private readonly ISalesModelService _isalesmodelservice;

        public SalesModelController(ISalesModelService isalesmodelservice)
        {
            _isalesmodelservice = isalesmodelservice;
        }		

		//GET api/SalesModel/RetrieveOne/{id}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(SalesModel), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<SalesModel> RetrieveOne(int id)
		{
			try
            {
				var result = _isalesmodelservice.RetrieveOne(id);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//GET api/SalesModel/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IList<SalesModel>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<IList<SalesModel>> Retrieve()
		{
			try
            {
				var result = _isalesmodelservice.Retrieve();
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/SalesModel/Create
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Create([FromBody]SalesModel salesmodel)
		{
			try
            {
				var result = _isalesmodelservice.Create(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/SalesModel/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Update([FromBody]IModelEntry<SalesModel> salesmodel)
		{
			try
            {
				var result = _isalesmodelservice.Update(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//POST api/SalesModel/Update1
		[HttpPost]
		[ActionName("Update1")]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Update([FromBody]SalesModel salesmodel)
		{
			try
            {
				var result = _isalesmodelservice.Update(salesmodel);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}

		//DELETE api/SalesModel/Delete/{id}
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public ActionResult<int> Delete(int id)
		{
			try
            {
				var result = _isalesmodelservice.Delete(id);
				
				return Ok(result);
			}
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
		}
	
	}
}
