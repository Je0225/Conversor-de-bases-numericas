using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.CalculosBases.Contratos;

namespace ConversorParaBinario.CalculosBases {
  internal class DecimalParaQualquerBase : ICalculo{

    public String Calcular(IBase baseValor, String valor) {
      Int32 numero = Convert.ToInt32(valor);
      String resultado = "";
      while (numero > 0) {
        Int32 mod = numero % baseValor.Base;
        numero = numero / baseValor.Base;
        String modString = mod.ToString();
        if (mod > 9) {
          switch (modString) {
            case "10":
              modString = "A";
              break;
            case "11":
              modString = "B";
              break;
            case "12":
              modString = "C";
              break;
            case "13":
              modString = "D";
              break;
            case "14":
              modString = "E";
              break;
            case "15":
              modString = "F";
              break;
          }
        }
        resultado = $"{modString}{resultado}";
      }
      return resultado;
    }

  }
}
