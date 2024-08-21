using Newtonsoft.Json;
using ReportImoveis.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportImoveis.Repository
{
    public class DataControl
    {
        public DataControl()
        {
            
        }
        public void SaveData(Presentation data)
        {
            using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecione a pasta para salvar a apresentação";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK
                && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                var DirectoryPath =
                    Path.Combine(folderBrowserDialog.SelectedPath, data.Titulo);

                Directory.CreateDirectory(DirectoryPath);

                var ApresentacaoPathName = Path.Combine(DirectoryPath, data.Titulo + ".txt");

                foreach (var item in data.Imoveis)
                {
                    item.ImagemImovelPath = ImageSave(DirectoryPath, item.ImagemImovelPath);
                }

                if (data.Corretor.ImageLocation is not null)
                {
                    data.Corretor.ImageLocation = ImageSave(DirectoryPath, data.Corretor.ImageLocation);
                }
                
                var arquivoDeApresentacao = JsonConvert.SerializeObject(data);
                
                File.WriteAllText(ApresentacaoPathName, arquivoDeApresentacao);
            }
        }

        private string ImageSave(string imageDirectoryPath, string imagePath)
        {
            if (imagePath is null)
            {
                return "";
            }
            var ImageName = Path.GetFileNameWithoutExtension(imagePath);
            var ImagemPath = Path.Combine(imageDirectoryPath, ImageName + ".jpg");
            if (!ImagemPath.Equals(imagePath))
            {
                var imagem = Image.FromFile(imagePath);
                imagem.Save(ImagemPath);
                return ImagemPath;
            }
            return imagePath;
        }

        public Presentation Carregar()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(openFileDialog1.FileName);
                return JsonConvert.DeserializeObject<Presentation>(data);
            }
            return null;
        }
    }
}
