using System;
using System.Text.RegularExpressions;

namespace ConversorParaBinario {

  public static class Calculos {

    public static String FazRegexDecimal(String entrada) {
      return Regex.Replace(entrada, @"[^\d]", "");
    }

    public static String FazRegexBinario(String entrada) {
      return Regex.Replace(entrada, @"[^01]", "");
    }

    public static String FazRegexOctal(String entrada) {
      return Regex.Replace(entrada, @"[^0-7]", "");
    }

    public static String FazRegexHexadecimal(String entrada) {
      return Regex.Replace(entrada, @"[^\dA - Fa-f]", "").ToUpper();
    }

    public static String DecimalParaQualquerBase(String valor, int baseResultdaConversao) {
      int numero = Convert.ToInt32(valor);
      String resultado = "";
      while (numero > 0) {
        int mod = numero % baseResultdaConversao;
        numero = numero / baseResultdaConversao;
        var modString = mod.ToString();
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

    public static String QualquerBaseParaDecimal(String valor, int BaseValor) {
      string d = "";
      int j = 0;
      double resultado = 0;

      for (int i = valor.Length - 1; i >= 0; i--) {
        if (Char.IsLetter(valor[i])) {
          switch (valor[i].ToString()) {
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
          resultado = resultado + (n * Math.Pow(BaseValor, j));
          j++;
        } else {
          Int32 n = Convert.ToInt32(valor[i].ToString());
          resultado = resultado + (n * Math.Pow(BaseValor, j));
          j++;
        }
      }
      return resultado.ToString();
    }

    public static String BinarioParaOctal(String valor) {
      //binário para decimal
      string dec = QualquerBaseParaDecimal(valor, 2);
      //decimal para octal
      String res = DecimalParaQualquerBase(dec, 8);
      return res;
    }

    public static String BinarioParaHexadecimal(String valor) {
      string resultado = "";

      while (valor.Length > 0) {
        Int32 tamanho = Math.Min(4, valor.Length);
        String pedaco = valor.Substring(valor.Length - tamanho, tamanho);
        valor = valor.Remove(valor.Length - tamanho, tamanho);
        String valorDecimal = QualquerBaseParaDecimal(pedaco, 2);
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

    public static String OctalParaBinario(String valor) {
      // octal para decimal
      String n = QualquerBaseParaDecimal(valor, 8);
      // decimal para binario;
      String res = DecimalParaQualquerBase(n, 2);
      return res;
    }

    public static String OctalParaHexa(string valor) {
      // octal para decimal
      string dec = QualquerBaseParaDecimal(valor, 8);
      //decimal para hexadecimal
      string hex = DecimalParaQualquerBase(dec, 16);
      return hex;
    }

    public static String HexaParaBinarioOuOctal(String valor, Int32 BaseBinOuOctal) {
      // hexadecimal para decimal
      string res = QualquerBaseParaDecimal(valor, 16);
      // hexadecimal para octal ou binário
      res = DecimalParaQualquerBase(res, BaseBinOuOctal);
      return res;
    }

  }

}