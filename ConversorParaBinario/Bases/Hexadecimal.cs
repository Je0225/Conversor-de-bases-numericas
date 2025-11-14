using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.RegexBases;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.Bases {
  internal class Hexadecimal : IBase {

    public IBaseRegex Regex { get; set; } = Registry.GetRegex<RegexHexadecimal>();

    public Int32 Base { get; } = 16;

    public override String ToString() {
      return this.GetType().Name;
    }

  }
}
