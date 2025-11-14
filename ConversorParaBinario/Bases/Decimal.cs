using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.RegexBases;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.Bases {
  internal class Decimal : IBase{

    public IBaseRegex Regex { get; set; } = Registry.GetRegex<RegexDecimal>();

    public Int32 Base { get; } = 10;

    public override String ToString() {
      return this.GetType().Name;
    }

  }
}
