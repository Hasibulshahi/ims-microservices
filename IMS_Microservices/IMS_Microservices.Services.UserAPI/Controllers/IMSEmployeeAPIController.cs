using IMS_Microservices.Services.UserAPI.Data;
using IMS_Microservices.Services.UserAPI.Models;
using IMS_Microservices.Services.UserAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMS_Microservices.Services.UserAPI.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class IMSEmployeeAPIController(AppDbContext db) : ControllerBase
    {
        private readonly AppDbContext _db = db;
        private readonly ResponseDto _response = new();

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<IMSEmployee> objList = _db.IMSEmployees.ToList();
                IMSEmployeeDto employeeDto = new();
                _response.Result = objList;                
            }
            catch (Exception ex)
            {
                _response.Result = ex.Message;
                _response.isSuccess = false;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                IMSEmployee obj = _db.IMSEmployees.First(x=>x.employeeID == id);
                IMSEmployeeDto employeeDto = new()
                {
                    employeeID = id,
                    email = obj.email,
                    firstName = obj.firstName,
                    lastName = obj.lastName,
                    password = obj.password,
                    phone = obj.phone
                };
                _response.Result = employeeDto;                
            }
            catch (Exception ex)
            {
                _response.Result = ex.Message;
                _response.isSuccess = false;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] IMSEmployeeDto iMSEmployeeDto) 
        {
            try
            {
                IMSEmployee obj = new()
                {
                    employeeID = iMSEmployeeDto.employeeID,
                    email = iMSEmployeeDto.email,
                    firstName = iMSEmployeeDto.firstName,
                    lastName = iMSEmployeeDto.lastName,
                    password = iMSEmployeeDto.password,
                    phone = iMSEmployeeDto.phone
                };
                _db.IMSEmployees.Add(obj);
                _db.SaveChanges();

                _response.Result = iMSEmployeeDto;
            }
            catch (Exception ex)
            {
                _response.isSuccess=false;
                _response.Message = ex.Message;
            }

            return _response;
        }
    }
}