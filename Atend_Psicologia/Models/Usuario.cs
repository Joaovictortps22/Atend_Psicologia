using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Atend_Psicologia.Models
{
    [Table("Usuarios")]
    public class Usuario : IUsuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string nome { get; set; }

        [Display(Name = "NomeSocial")]
        [Column("NomeSocial")]
        public string nomesocial { get; set; }

        [Display(Name = "Login")]
        [Column("Login")]
        public string login { get; set; }

        [Display(Name = "Password")]
        [Column("Password")]
        public string password { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string email { get; set; }

        [Display(Name = "Nascimento")]
        [Column("Nascimento")]
        public DateTime nascimento { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        public string cidade { get; set; }

        [Display(Name = "Bairro")]
        [Column("Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Estado")]
        [Column("Estado")]
        public string estado { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string telefone { get; set; }

        [Display(Name = "CPF")]
        [Column("CPF")]
        public string cpf { get; set; }

        [Display(Name = "Genero")]
        [Column("Genero")]
        public string genero { get; set; }

        [Display(Name = "Sobre")]
        [Column("Sobre")]
        public string sobre { get; set; }

        [Display(Name = "Role")]
        [Column("Role")]
        public string role { get; set; }
    }

    public interface IUsuario
    {

    }
}
