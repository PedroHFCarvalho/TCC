using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class EncVeiculos
    {
        private string id;
        private string nome;
        private string marca;
        private string placa;
        private string chassi;
        private string idCont;
        private string idMotorista;
        private string km;
        private string disp;
        private string categ;

        public EncVeiculos(string nome, string marca, string placa, string chassi,string km , string categ)
        {
            this.nome = nome;
            this.marca = marca;
            this.placa = placa;
            this.chassi = chassi;
            this.km = km;
            this.categ = categ;
        }
        public EncVeiculos(string id, string nome, string marca, string placa, string chassi, string km, string disp , string categ)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.placa = placa;
            this.chassi = chassi;
            this.km = km;
            this.disp = disp;
            this.categ = categ;
        }

        public EncVeiculos(string id, string nome, string marca, string placa, string chassi, string km, string categ)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.placa = placa;
            this.chassi = chassi;
            this.km = km;
            this.categ = categ;
        }


        public EncVeiculos(string id,string idCont)
        {
            this.id = id;
            this.idCont = idCont;
        }

        public EncVeiculos(string id, string idMotorista, string placa)
        {
            this.id = id;
            this.idMotorista = idMotorista;
            this.placa = placa;

        }

        public string IdV
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeV
        {
            get { return nome; }
            set { nome = value; }
        }

        public string MarcaV
        {
            get { return marca; }
            set { marca = value; }
        }
        public string PlacaV
        {
            get { return placa; }
            set { placa = value; }
        }
        public string ChassiV
        {
            get { return chassi; }
            set { chassi = value; }
        }
        public string KmV
        {
            get { return km; }
            set { km = value; }
        }
        public string IdCont
        {
            get { return idCont; }
            set { idCont = value; }
        }

        public string IdMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }
        }

        public string CategV
        {
            get { return categ; }
            set { categ = value; }
        }

        public string DispV
        {
            get { return disp; }
            set { disp = value; }
        }
    }
}
