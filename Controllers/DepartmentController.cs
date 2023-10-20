﻿using AngularCrudDemoWithRestApi.Model;
using AngularCrudDemoWithRestApi.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace AngularCrudDemoWithRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _department;
        public DepartmentController(IDepartmentRepository department)
        {
            _department = department ??
                throw new ArgumentNullException(nameof(department));
        }
        [HttpGet]
        [Route("GetDepartment")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _department.GetDepartment());
        }
        [HttpGet]
        [Route("GetDepartmentByID/{Id}")]
        public async Task<IActionResult> GetDeptById(int Id)
        {
            return Ok(await _department.GetDepartmentByID(Id));
        }
        [HttpPost]
        [Route("AddDepartment")]
        public async Task<IActionResult> Post(Department dep)
        {
            var result = await _department.InsertDepartment(dep);
            if (result.DepartmentId == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return new JsonResult("Added Successfully");
        }
        [HttpPut]
        [Route("UpdateDepartment")]
        public async Task<IActionResult> Put(Department dep)
        {
            await _department.UpdateDepartment(dep);

            return new JsonResult("Updated Successfully");
            //return Ok("");
        }
        [HttpDelete]
        //[HttpDelete("{id}")]
        [Route("DeleteDepartment")]
        public JsonResult Delete(int id)
        {
            _department.DeleteDepartment(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
