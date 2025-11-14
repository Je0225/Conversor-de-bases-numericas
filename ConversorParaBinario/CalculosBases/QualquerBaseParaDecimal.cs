using System;
using ConversorParaBinario.Bases.Contratos;
using ConversorParaBinario.CalculosBases.Contratos;

namespace ConversorParaBinario.CalculosBases {
  internal class QualquerBaseParaDecimal : ICalculo {

    public String Calcular(IBase baseValor, String valor) {
      String d = "";
      Int32 j = 0;
      Double resultado = 0;

      for (Int32 i = valor.Length - 1; i >= 0; i--) {
        if (Char.IsLetter(valor[i])) {
          switch (valor[i].ToString().ToUpper()) {
            case "A":
              d = "10";
              break;
            case "B":
              d = "11";
              break;
            case "C":
              d = "12";
              break;
            case "D":
              d = "13";
              break;
            case "E":
              d = "14";
              break;
            case "F":
              d = "15";
              break;
          }
          Int32 n = Convert.ToInt32(d);
          resultado = resultado + (n * Math.Pow(baseValor.Base, j));
          j++;
        } else {
          Int32 n = Convert.ToInt32(valor[i].ToString());
          resultado = resultado + (n * Math.Pow(baseValor.Base, j));
          j++;
        }
      }
      return resultado.ToString();
    }

  }
}
