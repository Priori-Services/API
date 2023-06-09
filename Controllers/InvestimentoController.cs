using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRIORI_SERVICES_API.Model;
using PRIORI_SERVICES_API.Shared;

namespace PRIORI_SERVICES_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InvestimentoController : ControllerBase
{
    private readonly PrioriDbContext _context;

    public InvestimentoController(PrioriDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetInvestimentos")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<Investimento>>> GetInvestimentos()
    {
        return await _context.tblInvestimentos.ToListAsync();
    }

    [HttpGet("{id}", Name = "GetInvestimentoById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<Investimento>>> GetInvestimentoFromID(int id)
    {
        Investimento? investimento = await _context.tblInvestimentos.FindAsync(id);

        if (investimento == null)
            return BadRequest(DefaultRequests.BAD_REQUEST);

        return Ok(investimento);
    }
}

