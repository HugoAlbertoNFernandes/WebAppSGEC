using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class ClienteEndereco
    {
        public ClienteEndereco()
        {

        }
        public int ClienteEnderecoid { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } //o endereço tem 1 unico cliente

    }
}
