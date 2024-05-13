using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dapper.Application.Interfaces;
using Dapper.Core.Entities;

namespace Dapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarriageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MarriageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWork.Marriages.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _unitOfWork.Marriages.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Marriage marriage)
        {
            var data = await _unitOfWork.Marriages.AddAsync(marriage);

            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _unitOfWork.Marriages.DeleteAsync(id);
            return Ok(data);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Marriage marriage)
        {
            var data = await _unitOfWork.Marriages.UpdateAsync(marriage);
            return Ok(data);
        }
    }
}
