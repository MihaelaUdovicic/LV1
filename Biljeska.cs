using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LV1
{
    class Biljeska
    {
       

        private String tekst, autor,razinaVaznosti;
        private int razin; //za 7. zad
        public string getTekst()
        {
            return this.tekst;
        }
        public string getAutor()
        {
            return this.autor;
        }
        public string getRazinaVaznosti()
        {
            return this.razinaVaznosti;
        }
        public void setTekst(string tekst)
        {
            this.tekst = tekst;    
        }
        public void setRazinaVaznosti(string razina)
        {
            this.razinaVaznosti = razina; 
        }
        private Biljeska(string autor)
        {
            this.autor = autor;
        }
        public Biljeska(string tekst, string razina)
        {
            setTekst(tekst);
            setRazinaVaznosti(razina);
            autor = "Ja";
        }
        public Biljeska()
        {
            setRazinaVaznosti("prva");
            setTekst("Svojstvo");
            autor = "Mojkod";
        }

        public Biljeska(string autor,string tekst,int razina) //za 7.
        {
            this.autor = autor;
            this.tekst = tekst;
            this.razin = razina;
        }
        public override string ToString()
        {
            return "Tekst: " + this.tekst + ", razina: " + this.razinaVaznosti;           //base.ToString();
        }

        static void Main(string[] args)
        {
            Biljeska a = new Biljeska("Autorsky");
            Console.WriteLine("Ime autora: " + a.getAutor());
            

            Console.WriteLine("Unesi tekst: ");
            string test = Console.ReadLine();

            Console.WriteLine("Unesi razinu: ");
            string raz = Console.ReadLine();

            Biljeska b=new Biljeska(test, raz);
            Console.WriteLine("Tekst o " + b.getTekst() + " s razinom " + b.getRazinaVaznosti());

            Biljeska r = new Biljeska();        //nisam sigurna da li je potrebno, 4. zad test
            Console.WriteLine("Razina: " + r.getRazinaVaznosti()+" radi se o "+r.getTekst()+", a ime autora: "+r.getAutor());
            Biljeska t = new Biljeska("opsirni tekstic", "druga");
            Console.WriteLine("Razina "+t.getRazinaVaznosti() + " s biljeskom "+t.getTekst() +", a ime autora: "+t.getAutor());

            Biljeska str = new Biljeska();
            Console.WriteLine(str.ToString());



            Vrijeme vr = new Vrijeme("Ja","test","200");
            Console.WriteLine(vr.ToString());


            List<Biljeska> lista = new List<Biljeska>();
            ToDo zad = new ToDo(lista);
            string a1, t1;
            int rv1;
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Unesi 1. autora, tekst i razinu vaznosti: ");
                a1 = Console.ReadLine();
                t1 = Console.ReadLine();
                rv1 = Convert.ToInt32(Console.ReadLine());
                zad.Add(a1, t1, rv1);
            }
                  

            int prioritet = 0;
            int maxPrioritet = lista[0].getRazinaVaznosti();
            for(int i = 0; i < lista.Count; i++)
            {
                if (i > i + 1)
                {
                    maxPrioritet = lista[i].getRazinaVaznosti();
                    prioritet = i;
                }
                zad.Remove(prioritet);
            }
            zad.Remove(0);

            Console.WriteLine(zad.numbersToString());
        }
    }
}
