using dobi;
using System;
using System.Linq.Expressions;
using System.Security.Claims;

internal class program
{
    private static void Main(string[] args)
    {
        List<Produkt> produkty = new List<Produkt>();//Stworzenie Listy produktow
        List<Magazyn> magazyny = new List<Magazyn>();//Stworzenie Listy magazynow
        produkty.Add(new Produkt("Nivea", "Krem", "Higiena osobista", 1, 1099, "Krem do pielegnacji ciala"));
        produkty.Add(new Produkt("Hortex", "Sok", "Napoje", 2, 999, "Sok jablkowy"));
        magazyny.Add(new Magazyn(null, new Adres("Miodowa 3/5", "42-444", "Warszawa", "64", "54")));
        for (; ; )
        {
            Console.WriteLine("1. Dodaj produkt" +
                "\n2. Edytuj produkt" +
                "\n3. Usun produkt" +
                "\n4. Dodaj magazyn" +
                "\n5. Edytuj magazyn" +
                "\n6. Usun magazyn" +
                "\n7. Dodaj produkt do magazynu" +
                "\n8. Usun produkt z magazynu"
                );
            //dodawanie / edycję / usuwanie magazynów, dodawanie / edycję / usuwanie produktów, dodawanie / usuwanie produktów z magazynu / ów

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Podaj nazwe producenta");
                            string producentt = Console.ReadLine();
                            Console.WriteLine("Podaj nazwe produktu");
                            string produktt = Console.ReadLine();
                            Console.WriteLine("Podaj kategoria");
                            string kategoriaa = Console.ReadLine();
                            Console.WriteLine("Podaj kod (liczba)");
                            int kodd = Convert.ToInt32(Console.ReadLine());//dodatnie
                            Console.WriteLine("Podaj cena (grosze)");
                            int cenaa = Convert.ToInt32(Console.ReadLine());//dodatnie
                            Console.WriteLine("Podaj opis");
                            string opiss = Console.ReadLine();

                            produkty.Add(new Produkt(producentt, produktt, kategoriaa, kodd, cenaa, opiss));
                        }
                        catch
                        {
                            Console.WriteLine("Pamietaj aby nie zostawic pustych pol, i przy kodzie i cenie podac liczbe");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Wybierz, ktory produkt chcesz edytowac");
                        for (int i = 0; i < produkty.Count; i++)
                        {
                            Console.WriteLine(i + " " + produkty[i].produkt);
                        }
                        try
                        {
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y < 0 || y > (produkty.Count - 1))
                            {
                                Console.WriteLine("Liczba nie miesci sie w zakresie");
                                
                            }
                            else
                            {
                                try
                                {

                                    Console.WriteLine("Podaj nazwe producenta");
                                    string producentt = Console.ReadLine();
                                    Console.WriteLine("Podaj nazwe produktu");
                                    string produktt = Console.ReadLine();
                                    Console.WriteLine("Podaj kategoria");
                                    string kategoriaa = Console.ReadLine();
                                    Console.WriteLine("Podaj kod (liczba)");
                                    int kodd = Convert.ToInt32(Console.ReadLine());//dodatnie
                                    Console.WriteLine("Podaj cena (grosze)");
                                    int cenaa = Convert.ToInt32(Console.ReadLine());//dodatnie
                                    Console.WriteLine("Podaj opis");
                                    string opiss = Console.ReadLine();

                                    produkty[y].producent = producentt;
                                    produkty[y].produkt = produktt;
                                    produkty[y].kategoria = kategoriaa;
                                    produkty[y].kod = kodd;
                                    produkty[y].cena = cenaa;
                                    produkty[y].opis = opiss;
                                    Console.WriteLine("Poprawnie edytowana produkt numer " + y);
                                }
                                catch
                                {
                                    Console.WriteLine("Pamietaj aby nie zostawic pustych pol, i przy kodzie i cenie podac liczbe");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podaj liczbe");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Wybierz, ktory produkt chcesz usunac");
                        for (int i = 0; i < produkty.Count; i++)
                        {
                            Console.WriteLine(i+" "+produkty[i].produkt);
                        }
                        try
                        {
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y < 0 || y > (produkty.Count - 1))
                            {
                                Console.WriteLine("Liczba nie miesci sie w zakresie");
                            }
                            else
                            {
                                
                                produkty.RemoveAt(y);
                                Console.WriteLine("Poprawnie usunieta produkt numer " + y);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podaj liczbe");
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("Dodaj magazyn");
                        try
                        {
                            Console.WriteLine("Ulica:");
                            string ulicaa = Console.ReadLine();
                            Console.WriteLine("Kod Pocztowy:");
                            string kodPocztowyy = Console.ReadLine();
                            Console.WriteLine("Miejscowosc:");
                            string miejscowoscc = Console.ReadLine();
                            Console.WriteLine("Numer posesji:");
                            string numerPosesjii = Console.ReadLine();
                            Console.WriteLine("numerLokalu:");
                            string numerLokaluu = Console.ReadLine();
                            magazyny.Add(new Magazyn(null, new Adres(ulicaa, kodPocztowyy, miejscowoscc, numerPosesjii, numerLokaluu)));
                        }
                        catch
                        {
                            Console.WriteLine("Pamietaj aby nie zostawic pustych pol, i przy numerPosesji i numerLokalu podac liczbe");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ktory magazyn chcesz usunac");
                        for (int i = 0; i < magazyny.Count; i++)
                        {
                            Console.WriteLine(i + " " + magazyny[i].adres.miejscowosc + " " + magazyny[i].adres.ulica);
                        }
                        try
                        {
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y < 0 || y > (produkty.Count - 1))
                            {
                                Console.WriteLine("Liczba nie miesci sie w zakresie");

                            }
                            else
                            {
                                try
                                {
                                    Console.WriteLine("Podaj numer nowej ulicy");
                                    string ulic = Console.ReadLine();
                                    Console.WriteLine("Podaj numego kodu pocztowego");
                                    string kodPocztow = Console.ReadLine();
                                    Console.WriteLine("Podaj nowa miejscowosc");
                                    string miejscowos = Console.ReadLine();
                                    Console.WriteLine("Podaj numer nowej numerPosesji");
                                    string numerPosesj = Console.ReadLine();
                                    Console.WriteLine("Podaj numer nowego numerLokalu");
                                    string numerLokal = Console.ReadLine();

                                    magazyny[y].adres.ulica = ulic;
                                    magazyny[y].adres.kodPocztowy = kodPocztow;
                                    magazyny[y].adres.miejscowosc = miejscowos;
                                    magazyny[y].adres.numerPosesji = numerPosesj;
                                    magazyny[y].adres.numerLokalu = numerLokal;

                                    Console.WriteLine("Poprawnie edytowana magazyn numer " + y);
                                }
                                catch
                                {
                                    Console.WriteLine("Pamietaj aby nie zostawic pustych pol, i przy numerPosesji i numerLokalu podac liczbe");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podaj liczbe");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ktory magazyn chcesz usunac");
                        for (int i = 0; i < magazyny.Count; i++)
                        {
                            Console.WriteLine(i + " " + magazyny[i].adres.miejscowosc +" "+magazyny[i].adres.ulica);
                        }
                        try
                        {
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y < 0 || y > (produkty.Count - 1))
                            {
                                Console.WriteLine("Liczba nie miesci sie w zakresie");
                            }
                            else
                            {

                                magazyny.RemoveAt(y);
                                Console.WriteLine("Poprawnie usunieta magazyn numer " + y);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podaj liczbe");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Dostepne magazyny");
                        for(int i = 0; i < magazyny.Count; i++)
                        {
                            Console.WriteLine(i + " " + magazyny[i].adres.miejscowosc + " " + magazyny[i].adres.ulica);
                        }
                        Console.WriteLine("Do ktorego magazynu chcesz przypisac produkty?");
                        try
                        {
                            int z = Convert.ToInt32(Console.ReadLine());
                            if (z < 0 || z > (magazyny.Count - 1))
                            {
                                Console.WriteLine("Wybrales zly magazyn");
                            }
                            else
                            {
                                Console.WriteLine("Ktory produkt chcesz przypisac do magazynu numer " + z);
                                for (int i = 0; i < produkty.Count; i++)
                                {
                                    Console.WriteLine(i + " " + produkty[i].produkt);
                                }
                                try
                                {
                                    int h = Convert.ToInt32(Console.ReadLine());
                                    if(h < 0 || h > (produkty.Count - 1))
                                    {
                                        Console.WriteLine("Wybrales zly Produkt");
                                    }
                                    else
                                    {
                                        magazyny[z].produkty.Add(produkty[h]);
                                        Console.WriteLine("Prawidlowo dodales produkt o id "+h+" do magazynu o id "+z);
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Podaj liczbe ;)");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podaj liczbe ;)");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Dostepne magazyny");
                        for (int i = 0; i < magazyny.Count; i++)
                        {
                            Console.WriteLine(i + " " + magazyny[i].adres.miejscowosc + " " + magazyny[i].adres.ulica);
                        }
                        Console.WriteLine("Wybierz z ktorego magazynu chcesz usunac produkt");
                        try
                        {
                            int k = Convert.ToInt32(Console.ReadLine());
                            if (k < 0 || k > (magazyny.Count))
                            {
                                Console.WriteLine("Wybrales zly magazyn");
                            }
                            else
                            {
                                Console.WriteLine("Ktory produkt chcesz usunac z magazynu numer " + k);

                                int i = 0;
                                foreach (Magazyn magazyny1 in magazyny)
                                {
                                    int d = i + 1;
                                    Console.WriteLine(i + " " + magazyny[k].produkty[i].produkt);
                                    i++;
                                }
                                try
                                {
                                    int h = Convert.ToInt32(Console.ReadLine());
                                    if (h < 0 || h > (produkty.Count))
                                    {
                                        Console.WriteLine("Wybrales zly Produkt");
                                    }
                                    else
                                    {
                                        magazyny[k].produkty.Remove(produkty[h]);
                                        Console.WriteLine("Prawidlowo usunoles produkt o id " + h + " z magazynu o id " + k);
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Podales zly produkt");
                                }

                            }
                        }
                        catch
                        {
                            Console.WriteLine("Podales zly magazyn");
                        }

                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Podaj jakas liczbe, najlepiej dodatnia :)");
            }
        }
    }
}