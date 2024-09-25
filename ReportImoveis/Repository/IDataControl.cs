using Newtonsoft.Json;
using ReportImoveis.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportImoveis.Repository
{
    public interface IDataControl
    {
        void SaveData(Presentation data);
        Presentation Carregar();
    }
}
