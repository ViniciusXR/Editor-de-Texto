using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_de_Texto
{
    public static class Gerenciador
    {
        //Define os valores padrões
        public static string CaminhoPastaPadrao = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\";
        public static string NomeArquivoPadrao = "arquivo";
        public static string NomeExtensaoPadrao = ".txt";

        //Valores atribuídos ao uso
        public static string CaminhoPasta { get; set; } = CaminhoPastaPadrao;
        public static string NomeArquivo { get; set; } = NomeArquivoPadrao;
        public static string NomeExtensao { get; set; } = NomeExtensaoPadrao;
        public static string CaminhoCompleto => CaminhoPasta + NomeArquivo + NomeExtensao;
    }
}
