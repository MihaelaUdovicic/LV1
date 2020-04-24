using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Vrijeme : Biljeska
    {

        private DateTime vrijeme;

        public void setVrijeme(DateTime vrijeme)
        {
            this.vrijeme = vrijeme;
        }
        public DateTime getVrijeme()
        {
            return this.vrijeme;
        }

        public Vrijeme(string autor,string tekst,string razinaVaznosti) : base(tekst, razinaVaznosti)
        {
            vrijeme = DateTime.Now;
        }


        public override string ToString()
        {
            return base.ToString()+", autor: "+getAutor()+"\nDatum: "+vrijeme.ToShortDateString();
        }

    }
}
