using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DTO
{
    public class EncDestino
    {
        private string dataSaida;
        private string dataChegada;
        private string idVeiculo;
        private string idDestino;
        private string km;
        private string ruaDestino;
        private string ruaSaida;
        private string idRota;

        public EncDestino(string dataSaida, string idVeiculo, string ruaDestino , string ruaSaida)
        {
            this.dataSaida = dataSaida;
            this.idVeiculo = idVeiculo;
            this.ruaDestino = ruaDestino;
            this.ruaSaida = ruaSaida;
        }

        public EncDestino(string idRota, string dataSaida, string dataChegada, string ruaSaida, string ruaDestino, string km)
        {
            this.idRota = idRota;
            this.dataSaida = dataSaida;
            this.dataChegada = dataChegada;
            this.ruaSaida = ruaSaida;
            this.ruaDestino = ruaDestino;
            this.km = km;
        }

        public string IdRota
        {
            get { return idRota; }
            set { idRota = value; }
        }
        public string DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        public string DataChegada
        {
            get { return dataChegada; }
            set { dataChegada = value; }
        }
        public string IdVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }
        }
        public string IdDestino
        {
            get { return idDestino; }
            set { idDestino = value; }
        }
        public string Km
        {
            get { return km; }
            set { km = value; }
        }
        public string RuaDestino
        {
            get { return ruaDestino; }
            set { ruaDestino = value; }
        }
        public string RuaSaida
        {
            get { return ruaSaida; }
            set { ruaSaida = value; }
        }

    }
}
