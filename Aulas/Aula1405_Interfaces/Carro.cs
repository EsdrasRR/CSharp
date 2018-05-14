﻿using System;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro, velocidade atual: " + Velocidade;
        }
    }
}