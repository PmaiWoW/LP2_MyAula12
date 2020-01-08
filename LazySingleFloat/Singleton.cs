using System;
using System.Collections.Generic;
using System.Text;

namespace LazySingleFloat
{
    public sealed class Singleton
    {
        // Instância única, privada, só inicializada quando necessário
        private static readonly Lazy<Singleton> instance =
            new Lazy<Singleton>(() => new Singleton());

        public float FltNum { get; set; }

        // Propriedade que devolve única instância
        public static Singleton Instance => instance.Value;

        // Construtor privado
        public Singleton() { }
    }
}
