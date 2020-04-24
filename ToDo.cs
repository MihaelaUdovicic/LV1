using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LV1
{
    class ToDo
    {
        public List<Biljeska> lista = new List<Biljeska> ();
       

        public ToDo(List<Biljeska> lista) 
        {
            this.lista = lista;
        }

        public void Add(string autor,string tekst,int razinaVaznosti)
        {
            Biljeska b = new Biljeska(autor,tekst, razinaVaznosti);
            lista.Add(b);
        }
        public void Remove(int index)
        {
            lista.RemoveAt(lista[index]);
        }
        

        public static String numbersToString(List<Biljeska> numbers)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            for(int i=0;i<lista.Count; i++)
            {
                stringBuilder.Append(i).Append(", ");
            }
            return stringBuilder.ToString();

        }

    }
}

