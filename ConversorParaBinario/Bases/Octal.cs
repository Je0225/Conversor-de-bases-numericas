using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.RegexBases;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.Bases {
  internal class Octal : IBase {

    public IBaseRegex Regex { get; set; } = Registry.GetRegex<RegexOctal>();

    public Int32 Base { get; } = 8;

    public override String ToString() {
      return this.GetType().Name;
    }

  }
}
