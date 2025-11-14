using System;
using ConversorParaBinario.Bases;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.CalculosBases;
using ConversorParaBinario.CalculosBases.Contratos;
using Decimal = ConversorParaBinario.Bases.Decimal;

namespace ConversorParaBinario {
  internal class Calculador {

    private ICalculo BinarioParaHexa { get; } = Registry.GetCalculo<BinarioParaHexadecimal>();

    private ICalculo DecimalParaOutraBase { get; } = Registry.GetCalculo<DecimalParaQualquerBase>();

    private ICalculo OutraBaseParaDecimal { get; } = Registry.GetCalculo<QualquerBaseParaDecimal>();

    public String Calcular(IBase baseAtual, IBase baseNova, String valor) {
      if (valor == "" || baseAtual.GetType() == baseNova.GetType()) {
        return valor;
      }
      if (baseAtual.GetType() == typeof(Binario) && baseNova.GetType() == typeof(Hexadecimal)) {
        return BinarioParaHexa.Calcular(baseAtual, valor);
      }
      if (baseAtual.GetType() != typeof(Decimal)) {
        valor = OutraBaseParaDecimal.Calcular(baseAtual, valor);
      }
      valor = DecimalParaOutraBase.Calcular(baseNova, valor);
      return valor;
    }

  }
}
