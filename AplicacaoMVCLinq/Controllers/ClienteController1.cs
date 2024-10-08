﻿using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCliente()
        {
            Cliente c1 = new Cliente(1, "Loh", "lorena.victor@aluno.senai.br", 121212, new DateOnly(2008, 02, 12));
            Cliente c2 = new Cliente(2, "Juju", "juliana.fulanetto@aluno.senai.br", 909090, new DateOnly(2008, 01, 15));
            Cliente c3 = new Cliente(3, "May", "maysa.rondon@aluno.senai.br", 454545, new DateOnly(2008, 06, 07));
            Cliente c4 = new Cliente(4, "Md", "matheus.dias@aluno.senai.br", 707070, new DateOnly(2009, 03, 08));
            Cliente c5 = new Cliente(5, "Mavi", "maria.vitoria@aluno.senai.br", 262626, new DateOnly(2011, 08, 26));

            //Criar uma lista de clientes
            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
