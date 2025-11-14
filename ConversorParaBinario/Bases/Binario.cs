using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.RegexBases;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.Bases {
  internal class Binario : IBase {

    public IBaseRegex Regex { get; set; } = Registry.GetRegex<RegexBinario>();

    public Int32 Base { get; } = 2;

    public override String ToString() {
      return this.GetType().Name;
    }

  }
}
