﻿using System.Collections.Generic;

namespace API_Juntos.Core.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; } 
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public List<Pedido> Pedidos { get; set; } 

    }
}
