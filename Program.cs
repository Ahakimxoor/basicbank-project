using System;

public class AcountBanking{


string isDiwaangelidaUserkaMagaciisa;
string isDiwaangelidaUserkaPasswordkiisa;
double haraaga;
public void isDiwaangelin (string name, string password)
{
    isDiwaangelidaUserkaMagaciisa = name;
    isDiwaangelidaUserkaPasswordkiisa = password;
    haraaga = 0.0;
}

public bool galidaAcount(string userName, string userPassword)
{
    return userName == isDiwaangelidaUserkaMagaciisa && userPassword == isDiwaangelidaUserkaPasswordkiisa;
}

public void Deposid (double amount)
{
    haraaga -= amount;
    Console.WriteLine($"waxaad ku guuleeysatay inaa dhigato lacag dhigasho {amount} haraagaagu cusub waa {haraaga }");
}

public void lacagKalabixid (double amount)
{
    if (amount <= haraaga)
    {
        haraaga -= amount;
        Console.WriteLine($"waad ku guuleysatay inaa la baxdo lacag {amount} haraagaagu cusub waa {haraaga} ");
    }
    else 
    {
        Console.WriteLine("naga raaalinoqo lacagta aa rabto inaa la baxdo kuguma jirto acount kaaga ");
    }
}

    public void HubintaHaraaga()
    {
        Console.WriteLine($"haraagagu waa {haraaga}");
    }

}
public class Program {
    public static void Main(string[] args){
        AcountBanking AcountBank = new AcountBanking();
        Console.WriteLine("fadlan so dhawaw macaamil is diwan geli ");
        Console.Write("faldan geli magaaca lagugu diwangelin lahaay  ");
        string magacaUserkaIsdiwaangelinayo = Console.ReadLine();
        Console.Write("faldan geli passwordka laguugu diwaan gelin lahaay ");
        string passwordUserkaIsdiwaangelinayo = Console.ReadLine();

        AcountBank.isDiwaangelin(magacaUserkaIsdiwaangelinayo, passwordUserkaIsdiwaangelinayo);

        Console.WriteLine("\n isku day hadda inaa acountgaaga gelisid  ");
        Console.Write("fadlan magaacaga geli   ");
        string userkaMagaciisa = Console.ReadLine();
        Console.Write("fadlan passworkaga geli  ");
        string userkaPasswordkiisa = Console.ReadLine();

        if (AcountBank.galidaAcount(userkaMagaciisa, userkaPasswordkiisa))
        {
            while(true)
            {
                Console.WriteLine("\nFadlan dooro mid ka mid ah xulashooyinka soo socda:");
                Console.WriteLine("1. Shub lacag (Deposit)");
                Console.WriteLine("2. Ka-noqosho lacag (Withdraw)");
                Console.WriteLine("3. Hubi lacagta ku jirta koontada (Check Balance)");
                Console.WriteLine("4. Ka bax nidaamka (Exit)");
                Console.Write("Dooro lambarkaaga: ");
                string dooqaUserka = Console.ReadLine();

                switch (dooqaUserka)
                {
                    case "1":
                    Console.Write("fadlan geli lacagta aa rabto inaa ku shubto ");
                    double KuShubidaLacagDhigashada = Convert.ToDouble(Console.ReadLine());
                    AcountBank.Deposid(KuShubidaLacagDhigashada);
                    break;
                    case "2":
                    Console.Write("fadlan geli lacagta aa rabtid ina kala noqotid ");
                    double lacagKalaNoqoshada = Convert.ToDouble(Console.ReadLine());
                    AcountBank.lacagKalabixid(lacagKalaNoqoshada);
                    break;
                    case "3":
                    AcountBank.HubintaHaraaga();
                    break;
                    case "4":
                    Console.WriteLine("waad ka baxday proceskan dhan bye marka ");
                    return;
                    default:
                    Console.WriteLine("fadlan dooro 4 taan number mid ka mid ah ");
                    break;
                    


                }
            }
        }

        else 
        {
            Console.WriteLine("fadlan password kaaga ama magacaga acount kaaga iska sax ");
        }
    }
}