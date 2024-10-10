using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace XPe.PrjAplicado.Interop.Repositories
{
    public class BaseRepository<T>
    {
        private const string CAMINHO = "C:\\E\\{0}.txt";
        public List<T> Dados { get; set; }

        private readonly string _nomeArquivo;

        public BaseRepository(string nomeArquivo)
        {
            _nomeArquivo = nomeArquivo;
            Read();
        }

        public string Arquivo { get { return string.Format(CAMINHO, _nomeArquivo);  } }

        protected void SaveChanges()
        {
            var entidadeSerealizada = JsonConvert.SerializeObject(Dados, Formatting.Indented);

            if (File.Exists(Arquivo))
                File.Delete(Arquivo);

            File.WriteAllText(Arquivo, entidadeSerealizada);
        }

        protected void Read()
        {
            if (File.Exists(Arquivo))
            {
                Dados = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(Arquivo));
            }
            else
            {
                Dados = new List<T>();
            }
        }
    }
}
