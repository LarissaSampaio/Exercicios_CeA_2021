using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class Pet
    {
        private string nome;
        private string tipo;
        public string Nome
        {
            get 
            { 
                return nome; 
            }
            set 
            { 
                nome = value; 
            }
        }
        public string Tipo
        {
            get 
            { 
                return tipo;
            }
            set 
            { 
                if(value == "Gato" || value == "Cachorro" || value == "Peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Peixe";
                }
                
            }
        }

    }
}
