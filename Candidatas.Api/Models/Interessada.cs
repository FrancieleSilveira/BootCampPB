using System.ComponentModel.DataAnnotations;

namespace Candidatas.Api.Models
{
    public record Interessada
    {
        public int Id { get; init; }

        public string Nome { get; init; }

        //[Required]
        public string Email { get; init; }
    }
}