using System;
using ConversorParaBinario.Bases.Contratos;

namespace ConversorParaBinario.CalculosBases.Contratos {
  internal interface ICalculo {

    String Calcular(IBase baseValor, String valor);

  }
}
