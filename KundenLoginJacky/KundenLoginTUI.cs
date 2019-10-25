using System;
using System.Collections.Generic;
using System.Text;
using KundenLoginJacky;

namespace KundenLoginJacky
{
    class KundenLoginTUI
    {
        

        public static void Main(String[]args)
        {
           

            List<Kunde> kundenListe = new List<Kunde>();

            String userNameInp, passwordInp, emailInp;

            char wdhderSchleife = ' ';
            do {
                Console.WriteLine("Bitte geben Sie ihren Username ein : ");
                userNameInp = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie ihren Password ein : ");
                passwordInp = Console.ReadLine();
                Console.WriteLine("Bitte geben Sie ihren Email ein : ");
                emailInp = Console.ReadLine();

                Kunde neuerKunde = new Kunde(userNameInp,passwordInp,emailInp);

                kundenListe.Add(neuerKunde);

                Console.WriteLine("Noch eine neuen Kunden hinzufügen ? ");

                wdhderSchleife = Console.ReadKey().KeyChar;
            } while (wdhderSchleife != 'n' && wdhderSchleife!='N');
            //TODO in Methode packen Ausgabe KundenListe
            foreach (Kunde kund in kundenListe) { Console.WriteLine(kund.ToString()); }
            kundenListe.Find(x => x.Username.Equals(userNameInp));
        }

    }
}
