using System;
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

    public static void Registrar<T>(ICalculo calculo) where T : ICalculo{
      calculos.Add(typeof(T), calculo);
    }

    public static void Registrar<T>(IBaseRegex baseRegex) where T : IBaseRegex{
      regexEntradas.Add(typeof(T), baseRegex);
    }

    public static void Registrar<T>(IBase baseNumerica) where T : IBase {
      bases.Add(typeof(T), baseNumerica);
    }
  }
}
