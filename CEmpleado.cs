using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CEmpleado
    {
        private string nombres;
        private string categoria;
        public int tardanza;
        public int atencion;

        public string Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                nombres = value;
            }

        }
        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }
        public int Tardanza
        {
            get
            {
                return tardanza;
            }
            set
            {
                tardanza = value;
            }
        }
        public int Atencion
        {
            get
            {
                return atencion;
            }
            set
            {
                atencion = value;
            }
        }

       public double Calcular_sueldo()
        {
            double sueldo = 0;
            switch(categoria)
            {
                case "A": sueldo = 2500;break;
                case "B": sueldo = 1500;break;
                case "C": sueldo = 1000; break;
                case "D": sueldo = 900;break;
                default: sueldo = 900;break;
            }
            return sueldo;
        }
        public double Calcular_pago()
        {
            if(Tardanza>0||Atencion>0)
            {
                return Calcular_sueldo() - Tardanza * 5 - Atencion * 10;
            }
            else
            {
                return Calcular_sueldo() * 1.15;
            }
        }
    }
}
