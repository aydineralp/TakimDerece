namespace GoogleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golSayisi = 0;
            string takimSeviyesi = "";
            Random sayi = new Random(); //rastgele sayı üret
            golSayisi = sayi.Next(0, 6); // iki integer değer arası döndürecek.
            Console.WriteLine(golSayisi);
            switch (golSayisi)
            {
                case 1:
                    takimSeviyesi = "OK";
                    break;

                    case 2:
                    takimSeviyesi = "GUZEL";
                    break;

                    case 3:
                    takimSeviyesi = "YUKSEK";
                    break;

                    case 4:
                    takimSeviyesi = "MUHTESEM";
                    break;

                    case 5:
                    takimSeviyesi = "WOW";
                    break;
                default: //Switch case yapısında tanımlanmayan bir durum gerçekleştiğinde olmasını istediğimiz durumu default bölümüne yazarız. 
                    takimSeviyesi = "KOTU";
                    break;

            }
            Console.WriteLine(takimSeviyesi);
            Console.ReadLine();
        }
    }
}
