﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementação realizada
            string adicionarPlaca = "";

            Console.Write("Digite a placa do veículo para estacionar: ");
            adicionarPlaca = Console.ReadLine();

            veiculos.Add(adicionarPlaca);
        }

        public void RemoverVeiculo()
        {

            // Implementação realizada
            Console.Write("Digite a placa do veículo para remover: ");

            string placa = "";

            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Implementação realizada
                int horas = 0;
                decimal valorTotal = 0;

                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + precoPorHora * horas;

                // Implementação realizada
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementação realizada
                foreach (string item in veiculos) {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}