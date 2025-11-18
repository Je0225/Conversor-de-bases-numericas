using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.CalculosBases.Contratos;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario {
  internal static class Registry {

    private static readonly Dictionary<Type, ICalculo> calculos = new Dictionary<Type, ICalculo>();

    private static readonly Dictionary<Type, IBaseRegex> regexEntradas = new Dictionary<Type, IBaseRegex>();

    private static readonly Dictionary<Type, IBase> bases = new Dictionary<Type, IBase>();

    public static IBaseRegex GetRegex<T>() where T : IBaseRegex {
      return regexEntradas[typeof(T)];
    }

    public static ICalculo GetCalculo<T>() where T : ICalculo {
      return calculos[typeof(T)];
    }

    public static IBase[] GetBases() {
      return bases.Values.ToArray();
    }

    public static void Registra(ICalculo calculo) {
      calculos.Add(typeof(ICalculo), calculo);
    }

    public static void Registra(IBaseRegex baseRegex) {
      regexEntradas.Add(typeof(IBaseRegex), baseRegex);
    }

    public static void Registra(IBase baseNumerica) {
      bases.Add(typeof(IBase), baseNumerica);
    }
  }
}
