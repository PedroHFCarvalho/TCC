using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DTO
{
    public class EncManut
    {
        private string dataEntrada;
        private string dataSaida;
        private string idVeiculo;
        private string idManut;
        private string observ;

        public EncManut(string dataEntrada, string idVeiculo, string observ)
        {
            this.dataEntrada = dataEntrada;
            this.observ = observ;
            this.idVeiculo = idVeiculo;
        }

        public EncManut(string dataEntrada, string dataSaida, string observ, string idManut)
        {
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
            this.observ = observ;
            this.idManut = idManut;
        }

        public string DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        public string DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        public string Observ
        {
            get { return observ; }
            set { observ = value; }
        }
        public string IdVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }
        }
        public string IdManut
        {
            get { return idManut; }
            set { idManut = value; }
        }
    }
}
