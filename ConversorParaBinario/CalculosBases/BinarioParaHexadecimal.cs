using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.CalculosBases.Contratos;

namespace ConversorParaBinario.CalculosBases {
  internal class BinarioParaHexadecimal : ICalculo {

    private readonly ICalculo calculoParaDecimal = Registry.GetCalculo<QualquerBaseParaDecimal>();

    public String Calcular(IBase baseValor, String valor) {
      String resultado = "";

      while (valor.Length > 0) {
        Int32 tamanho = Math.Min(4, valor.Length);
        String pedaco = valor.Substring(valor.Length - tamanho, tamanho);
        valor = valor.Remove(valor.Length - tamanho, tamanho);
        String valorDecimal = calculoParaDecimal.Calcular(baseValor, pedaco);
        Int32 numero = Convert.ToInt32(valorDecimal);
        if (numero > 9) {
          switch (numero) {
            case 10:
              valorDecimal = "A";
              break;
            case 11:
              valorDecimal = "B";
              break;
            case 12:
              valorDecimal = "C";
              break;
            case 13:
              valorDecimal = "D";
              break;
            case 14:
              valorDecimal = "E";
              break;
            case 15:
              valorDecimal = "F";
              break;
          }
        }
        resultado = $"{valorDecimal}{resultado}";
      }
      return resultado;
    }

  }
}
