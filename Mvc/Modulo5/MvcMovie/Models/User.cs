using System.ComponentModel.DataAnnotations;
using Cripto;

namespace MvcMovie.Models;

public class User
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }

    public void SetSenhaHash(){
        Senha = Senha.GerarHash();
    }
}
