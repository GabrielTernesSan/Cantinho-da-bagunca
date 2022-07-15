using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        // Só vai atender se na URL existirem valores alfanuméricos (A-Z)
        // [HttpGet("{valor:alpha}")]
        // [HttpGet("{valor:alpha:length(5)}")]
        // [HttpGet("{valor:alpha:maxlength(5)}")]
        public ActionResult<IEnumerable<Produto>> Get() {
            var produtos = _context.Produtos.AsNoTracking().Take(10).ToList();
            if (produtos is null) {
                return NotFound("Produtos não encontrados...");
            }
            return produtos;
        }

        // Restrição de rota. Evita que o usuário digite um valor menor que 1
        [HttpGet("{id:int:min(1)}", Name="ObterProduto")]
        //[HttpGet("{id:int}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id) {
            var produto = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null) {
                return NotFound();            
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto) {
            if (produto is null) {
                return BadRequest();
            }
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto) { 
            if(id != produto.ProdutoId) {
                return BadRequest();
            }
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            //var produto = _context.Produtos.Find(id);
         
            if(produto is null) {
                return BadRequest("Produto inexistente...");
            }
            //_context.Entry(produto).State = EntityState.Deleted;
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok();
        }
    }
}
