using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutoWebAPI.Context;
using ProdutoWebAPI.Models;

namespace ProdutoWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> GetProdutoById(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(p => p.Id == id);

            if (categoria is null)
            {
                return NotFound("Categoria não encontrada");
            }

            return Ok(categoria);
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return _context.Categorias.Include(p => p.Produtos).ToList();
        }

        [HttpPost]
        public ActionResult<Categoria> PostCategoria(Categoria categoria)
        {
            if (categoria == null)
                return BadRequest();

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCatergoria", new { id = categoria.Id }, categoria);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Categoria> PutCategoria(int id, Categoria categoria)
        {
            if (id != categoria.Id)
                return BadRequest("Categoria não encontrada");

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(categoria);
        }
    }
}
