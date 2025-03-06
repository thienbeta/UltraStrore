using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UltraStrore.Data.Temp;
using UltraStrore.Repository;

namespace UltraStrore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamServices services;

        public SanPhamController(ISanPhamServices services)
        {
            this.services = services;
        }
        [HttpGet("ListSanPham")]
        public async Task<IActionResult> ListSanPham(string? id)
        {
            var data = await this.services.ListSanPham(id);
            return Ok(data);
        }
        [HttpGet("SanPhamByID")]
        public async Task<IActionResult> SanPhamByID(string id)
        {
            var data = await this.services.SanPhamByID(id);
            return Ok(data);
        }
        [HttpPost("NewSanPham")]
        public async Task<IActionResult> NewSanPham()
        {
            return Ok();
        }
    }
}
