using IMS_Microservices.Services.MenuAPI.Data;
using IMS_Microservices.Services.MenuAPI.Models;
using IMS_Microservices.Services.MenuAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IMS_Microservices.Services.MenuAPI.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class IMSMenuAPIController(AppDbContext db) : ControllerBase
    {
        private readonly AppDbContext _db = db;
        private readonly ResponseDto _response = new();

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<IMSMenu> objList = _db.IMSMenus.ToList();
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
                IMSMenu obj = _db.IMSMenus.First(x => x.menuID == id);
                IMSMenuDto menuDto = new()
                {
                    menuID = id,
                    manuName = obj.manuName,
                    category = obj.category,
                    price = obj.price
                };
                _response.Result = menuDto;
            }
            catch (Exception ex)
            {
                _response.Result = ex.Message;
                _response.isSuccess = false;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] IMSMenuDto iMSMenuDto)
        {
            try
            {
                IMSMenu obj = new()
                {
                    menuID = iMSMenuDto.menuID,
                    manuName = iMSMenuDto.manuName,
                    category = iMSMenuDto.category,
                    price = iMSMenuDto.price
                };
                _db.IMSMenus.Add(obj);
                _db.SaveChanges();

                _response.Result = iMSMenuDto;
            }
            catch (Exception ex)
            {
                _response.isSuccess = false;
                _response.Message = ex.Message;
            }

            return _response;
        }
    }
}
