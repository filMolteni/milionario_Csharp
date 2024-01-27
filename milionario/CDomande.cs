using System;
using System.Collections.Generic;
using System.Text;

namespace milionario
{
    class CDomande
    {
        public string domanda { get; set; }
        public string risp1 { get; set; }
        public string risp2 { get; set; }
        public string risp3 { get; set; }
        public string risp4 { get; set; }

        public void pag1()
        {
            this.domanda = "chi è il presidente della repubblica?";
            this.risp1 = "bo";
            this.risp2 = "Mattarella";
            this.risp3 = "Sfera Ebbasta";
            this.risp4 = "Gimbo Tamberi";
        }

        public void pag2()
        {
            this.domanda = "chi è tra questi un cantante?";
            this.risp1 = "bo";
            this.risp2 = "Mattarella";
            this.risp3 = "Sfera Ebbasta";
            this.risp4 = "Gimbo Tamberi";
        }

        public void pag3()
        {
            this.domanda = "chi è tra questi un atleta?";
            this.risp1 = "bo";
            this.risp2 = "Mattarella";
            this.risp3 = "Sfera Ebbasta";
            this.risp4 = "Gimbo Tamberi";
        }


    }
}
