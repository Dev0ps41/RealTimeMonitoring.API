using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealTimeMonitoring.API.Data;
using RealTimeMonitoring.API.Models;

namespace RealTimeMonitoring.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductionDataController> _logger;

        public ProductionDataController(ApplicationDbContext context, ILogger<ProductionDataController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductionData>>> GetProductionData()
        {
            try
            {
                return await _context.ProductionData.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in GetProductionData: {Message}", ex.Message);
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductionData>> PostProductionData(ProductionData productionData)
        {
            try
            {
                _context.ProductionData.Add(productionData);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetProductionData), new { id = productionData.Id }, productionData);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in PostProductionData: {Message}", ex.Message);
                return StatusCode(500, "Internal Server Error: " + ex.Message);
            }
        }
    }
}
