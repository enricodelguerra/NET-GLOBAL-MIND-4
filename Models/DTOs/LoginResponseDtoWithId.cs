// DTO para resposta de login com ID do usuário
namespace nexus.Models.DTOs
{
    public class LoginResponseDtoWithId : LoginResponseDto
    {
        public int IdUsuario { get; set; }
    }
}