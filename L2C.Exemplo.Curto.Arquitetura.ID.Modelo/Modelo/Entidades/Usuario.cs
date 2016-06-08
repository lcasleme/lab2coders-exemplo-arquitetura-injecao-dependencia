using System;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            UsuarioId = Guid.NewGuid();
        }

        public Guid UsuarioId { get; set; }

        public int CodigoUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int FlagAtivo { get; set; }
    }
}