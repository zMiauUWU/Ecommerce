using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{

    public string Metodo()
    {
        return "hello world ";
    }
    
  
}