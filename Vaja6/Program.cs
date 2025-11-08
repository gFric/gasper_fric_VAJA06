using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
	//Naredimo razred igralec, ki vsebuje podatke o igralcu
    class Igralec {
        private int id;
        private string u_ime;
        private string u_geslo;
        private static int stIg = 1;

		//privzeti konstruktor, ki nastavi osnovne podatke igralca
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

		//Naredimo lastnosti, ki vrne Id igralca
        public int Id {
            get
            {
                return id;
            }
        }

		//Lastnost U_ime, ki ji nastavimo vrednost na u_ime in jo trim-amo
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
		
		//Naredi isto kot prejšnja lastnost ampak za u_geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

		//Statična lastnost, ki vrne število igralcev - stIg
        public static int StIg
        {
            get { return stIg; }
        }
    }
	
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
