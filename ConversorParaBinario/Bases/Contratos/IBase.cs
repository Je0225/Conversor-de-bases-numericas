using System;
using ConversorParaBinario.RegexBases.Contratos;

namespace ConversorParaBinario.Bases.Contratos {
  internal interface IBase {

    IBaseRegex Regex { get; set; }

    Int32 Base { get; }

  }
}
