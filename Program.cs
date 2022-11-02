string username = "admin";
string pasword = "12345";
Console.WriteLine("\t\t\t\t\twelcome to bank");
Console.Write("ad daxil edin: ");
username =(Console.ReadLine());
Console.Write("kod daxil edin: ");
pasword = (Console.ReadLine());
int qalan_ay = 0;
int faiz = 0;
int odenilecek_mebleg = 0;
int ayliq_odenis = 0;
int qalan_borc = 0;
int ay = 0;
int mebleg = 0;
o:
if (username == "admin" || pasword == "admin")
   
{
    Console.WriteLine("1.kredit goturmek");
    Console.WriteLine("2 kredit odemek");
    Console.WriteLine("3.hesabat");
}
else
{
    Console.WriteLine("emalyat ugursuz");
}
Console.Write("emaliyat: "); 
string emaliyat = (Console.ReadLine());

if (emaliyat == "1")
{
    Console.Write("ay daxil edin :");
    ay = int.Parse(Console.ReadLine());
    Console.Write("meblegi daxil edin:");
    mebleg = int.Parse(Console.ReadLine());
    if (ay <= 12)
    {
        Console.Write("odenilecek mebleg:");
        Console.WriteLine(odenilecek_mebleg = mebleg * 12/100 + mebleg);
        Console.Write("ayliq odenilecek mebleg:");
        Console.WriteLine(odenilecek_mebleg/ay);
        Console.Write("razisiniz?\n1.beli\n2.xeyr\ndaxil edin: ");
        int razisiz = int.Parse(Console.ReadLine());
        switch (razisiz)
        {
            case 1:
                Console.WriteLine("emaliyat ugurlu oldu!");
                break;
            case 2:
                Console.WriteLine("emaliyat legv olundu");
                break;
            default:
                Console.WriteLine("ugursuz cehd");
                break;
                Console.WriteLine("indiki borcunuz:");
                Console.WriteLine(odenilecek_mebleg);
        }
    }
    else if (ay >= 12 && ay <= 18)
      {
        Console.Write("odenilecek mebleg:");
        Console.WriteLine(odenilecek_mebleg = mebleg * 18/100 + mebleg);
        Console.Write("ayliq odenilecek mebleg:");
        Console.WriteLine(odenilecek_mebleg/ay);
        Console.Write("razisiniz?\n1.beli\n2.xeyr");
        int razisiz = int.Parse(Console.ReadLine());
        switch (razisiz)
        {
            case 1:
                Console.WriteLine("emaliyat ugurlu oldu!");
                break;
            case 2:
                Console.WriteLine("emaliyat legv olundu");
                break;
            default:
                Console.WriteLine("ugursuz cehd");
                break;
                Console.WriteLine("indiki borcunuz:");
                Console.WriteLine(odenilecek_mebleg);
        }
      }
    else
    {
        Console.WriteLine("kredit elde etmek mumkun olmadi!");
    }
}
else if (emaliyat == "2")
{
    Console.Write("ay daxil edin :");
    ay = int.Parse(Console.ReadLine());
    Console.Write("meblegi daxil edin:");
    mebleg = int.Parse(Console.ReadLine());
    Console.WriteLine(ayliq_odenis = odenilecek_mebleg/ay);
    Console.Write("odemek ucun 1 basin: ");
    int odenis = int.Parse(Console.ReadLine());
    switch (odenis)
    {
        case 1:
            Console.WriteLine("odenis ugurlu oldu!");
            break;
    }
    Console.Write("qalan borc: ");
    Console.WriteLine(qalan_borc = odenilecek_mebleg - ayliq_odenis);
    Console.Write("qalan ay: ");
    Console.WriteLine(qalan_ay = ay--);
    Console.Write("menyu qayitmaq ucun o cilick edin.");
    goto o;
}
else if (emaliyat == "3")
{
    Console.Write("ay daxil edin :");
    ay = int.Parse(Console.ReadLine());
    Console.Write("meblegi daxil edin:");
    mebleg = int.Parse(Console.ReadLine());
    Console.Write("qalan borc: ");
    Console.WriteLine(qalan_borc = odenilecek_mebleg - ayliq_odenis);
    Console.Write("qalan ay: ");
    Console.WriteLine(qalan_ay = ay--);
}
else
{
    Console.WriteLine("ugursuz cehd");
}


