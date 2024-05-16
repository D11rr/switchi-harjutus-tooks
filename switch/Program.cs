namespace switchi;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("INK");
        Console.WriteLine("kirjuta 1 et valida nimekirjast, 2 et jah");
        string valik = Console.ReadLine();
        if (valik == "1")
        {
            hee();
        }
        else if (valik == "2")
        {
            Console.WriteLine("SIIN POLE NIMEKIRJA");
        }
       

        
    }
    static void hee()
    {
Console.WriteLine("vali 1-3 et saaada nimi");
        string numba = Console.ReadLine();
        
        switch (numba)
        {
            case "1":
                Console.WriteLine("Toivo");
                break;
            case "2":
                Console.WriteLine("Uibo");
                break;
            case "3":
                Console.WriteLine("Jarmo");
                break;
            default:
                Console.WriteLine("Sa ei valinud õiget numbrit. Saad Kaja Kallas");
                break;
        }
    }
}
