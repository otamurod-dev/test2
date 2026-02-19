//Console.WriteLine("birinchi sonni kiriting");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("ikkinchi sonni kiriting");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"yigindisi   {a + b}");
//Console.WriteLine($"ayirmasi    {a - b}");
//Console.WriteLine($"ko'paytmasi {a * b}");
//Console.WriteLine($"bo'linmasi  {a / b}");
//Console.WriteLine($"qoldiq  {a % b}");

//Console.WriteLine("Uchburchaknig yuzasini hisoblash uchun bir tamoni uzunligini yozing");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("ikkinchi tamonini uzunligini yozing");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Uchburchakning yuzasi {(a*b)/2} ekan");

//Console.WriteLine("To'rtburchakning balandligini yozing");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("To'rtburchakning enini y());ozing");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"To'rtburchakning permetri  {a*2+b*2}");
//Console.WriteLine($"To'rburchakning yuzasi  {a*b}");

//Console.WriteLine("son kiriting");
//int a = int.Parse(Console.ReadLine());
//if (a % 5 == 0) 
//{
//    Console.WriteLine("kiritilgan son qoldiqsiz bo'linadi");
//}

//else
//{
//    Console.WriteLine("kiritilgan son qoldiqli bo'linadi");
//}

//Console.WriteLine("son kiriting");
//int a = int.Parse(Console.ReadLine());
//if (a % 5 == 2)
//{
//    Console.WriteLine("bu sonni 5 ga bolganda 2 qoldiq qoladi");
//} 
//else
//{
//    Console.WriteLine("2 qoldiq qolmaydi");
//}


//Console.WriteLine("son kiriting");
//int a = int.Parse(Console.ReadLine());
//if (a % 4 == 0)
//{
//    Console.WriteLine("siz kiritgan son 4 ga bo'linadi");
//}
//else
//{
//    Console.WriteLine("siz kiritgan son 4 ga qoldiqsiz bo'linmaydi");
//}
//if (a<10)
//{
//    Console.WriteLine("siz kiritgan son 10 dan kichik");

//}
//else
//{
//    Console.WriteLine("siz kiritgan son 10 dan katta");
//}


//Console.WriteLine("raqam kiritng");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("raqam kiritng");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"permetri {(a*2)+(b*2)} Yuzasi {a*b}");


//Console.WriteLine("son kiriting");
//int a = int.Parse(Console.ReadLine());
//if (a % 5 == 2)
//{
//    Console.WriteLine(" ye beby");
//}
//else
//{
//    Console.WriteLine("chichib qoydiz tog'a");
//}

//Console.Write("login kiriting\n>>>");
//string user = Console.ReadLine();
//string login = "fahriddin12";
//string passvord = "ye beby";
//Console.Write("parolni kiriting\n>>>");
//string userp = Console.ReadLine();
//if (user == login && userp == passvord)
//{
//    Console.WriteLine("login va parol to'g'ri");
//}
//else
//{
//    Console.WriteLine("notg'ri login yoki parol");
//}


// 8- DARS--------------------------

//Console.WriteLine("son kiriting>>>");
//int a = int.Parse(Console.ReadLine());
//if (a % 2 == 0)
//{
//    Console.WriteLine("siz kiritgan son \"juft\"");
//}
//else
//{
//    Console.WriteLine("siz kiritgan son \"Toq\"");
//}

//Console.WriteLine("Go'zallik dunyoni qutqari deyishadi, men qanchalar go'zalman 1 dan 5 gacha baholang");
//int baho = int.Parse(Console.ReadLine());
//if  (baho == 1)
//{
//    Console.WriteLine("man shunaqa hunukmanmi");
//}
//else if (baho == 2)
//{
//    Console.WriteLine("loy ekansiz");
//}
//else if (baho == 3)
//{
//    Console.WriteLine("bo'ladi yomonmas demoqchisizda");
//}
//else if (baho == 4)
//{
//    Console.WriteLine("rahmat tushunadiganlar ham bor ekanku");
//}
//else
//{
//    Console.WriteLine("demak dunyoni men qutqararkanman urraaaa");
//}


//Console.WriteLine("yoshingiz nechchida? ");
//int yosh = int.Parse(Console.ReadLine());
//if (yosh<7)
//{
//    Console.WriteLine("demak siz bog'chaga borsez kerak");
//}
//else if  (yosh<19)
//{
//    Console.WriteLine("maktabdan qochishlar bolmaydimi ukajon");
//}
//else if (yosh<23)
//{
//    Console.WriteLine("universitetdagi qizlar boshigizni aylantirib qo'ymayabdimi?");
//}
//else if (yosh<60)
//{
//    Console.WriteLine("ishlar joyidami tog'a");
//}
//else
//{
//    Console.WriteLine("pensiyani vaqtida berishyabdmi ota");
//}



//Console.WriteLine("Yoshizi ayting nima qilishizi aytaman....");
//int yosh = int.Parse(Console.ReadLine());

//if (yosh < 7)
//{
//    Console.WriteLine("Xali malakasos ekansu, og'zizdan sutti xidi ketmabdi");
//}
//else if (yosh < 19)
//{
//    Console.WriteLine("maktabda ikki olmayabsanm toy bola");
//}
//else if (yosh < 23)
//{
//    Console.WriteLine("Instutni tugat zaybal");
//}
//else
//{
//    Console.WriteLine("bu yog'i taqdir ishla");
//}


//using System.ComponentModel;
//Console.WriteLine("mashina modelini yozing");
//string model = Console.ReadLine();
//string zavod;
//switch (model)
//{
//    case "arava":
//    case "teshik tog'ara":
//    case "eshshak":

//        zavod = "GM da ishlab chiqarilgan";
//        break;
//      default:
//        zavod = "nomalum";
//        break;
//}
//Console.WriteLine(zavod);


//Console.WriteLine("sizda sovg'a yutish imkoniyati bor, 1 dan 5 gacha raqam kiriting");
//int a = int.Parse(Console.ReadLine());
//string natija = a switch
//{
//    1 => "kobalt",
//    2 => "maluba",
//    3 => "tico",
//    4 => "camaro",
//    _ => "sizga zambarakni o'qi paaaq"
//};
//Console.WriteLine(natija);






//Console.WriteLine("1 dan 12 gacha son kiriting");
//int a = int.Parse(Console.ReadLine());
//string natija;
//switch (a)
//{
//    case 1:
//        natija = "yanvar";
//        break;
//    case 2:
//        natija = "fevral";
//        break;
//    case 3:
//        natija = "mart";
//        break;
//        case 4:
//        natija = "aprel";
//        break;
//        case 5:
//        natija = "may";
//        break;
//        case 6:
//        natija = "iyun";
//        break;
//        case 7:
//        natija = "iyul";
//        break;
//        case 8:
//        natija = "avgust";
//        break;
//        case 9:
//        natija = "sentabr";
//        break;
//        case 10:
//        natija = "oktabr";
//        break;
//        case 11:
//        natija = "noyabr";
//        break;
//        case 12:
//        natija = "dekabr";
//        break;
//        default:
//        natija = "nomalum";
//        break;
//};
//Console.WriteLine($"siz kiritgan son {natija} ga to'g'ri kelarkan");



//Console.WriteLine("1 dan 12 gacha son kiriting");
//int a = int.Parse(Console.ReadLine());
//string natija = a switch
//{
//  1 => "yanvar",
//  2=>"fevral",
//  3=>"mart",
//  4=>"aprel",
//  5=>"may",
//  6=>"iyun",
//  7=>"iyul",
//  8=>"avgust",
//  9=>"sentabr",
//  10=>"oktabr",
//  11=>"noyabr",
//  12=>"dekabr",
//  _=>"siz noto'g'ri raqam kiritingiz"
//};
//Console.WriteLine(natija);



//Console.WriteLine("1 dan 12 gacha son kiriting");
//int a = int.Parse(Console.ReadLine());
//string natija;
//switch (a)
//{
//    case 1:
//        case 2:
//        natija = "qish";
//        break;
//        case 3:
//        case 4:
//        case 5:
//        natija = "bahor";
//        break;
//    case 6:
//    case 7:
//    case 8:
//        natija = "yoz";
//        break;
//    case 9:
//    case 10:
//    case 11:
//        natija = "kuz";
//        break;
//    default:
//        natija = "noto'g'ri son kiritdingiz";
//        break;
//}
//Console.WriteLine($"siz kiritgan son {natija} fasliga to'g'ri kelarkan");



//Console.WriteLine("son kriting");
//double son1 = double.Parse(Console.ReadLine());

//Console.WriteLine("quyidagi amallardan birini tanlang *, /, +, -");
//string amal = (Console.ReadLine());

//Console.WriteLine("son kiriting");
//double son2 = double.Parse(Console.ReadLine());
//double natija;
//switch (amal)
//{
//    case "*":
//        natija = son1 * son2;
//        break;
//    case "/":
//        if (son2 != 0)
//        {
//            natija = son1 / son2;
//        }
//        else
//        {
//            Console.WriteLine("nolga bo'lib bo'lmaydi");
//            return;
//        }

//        break;
//    case "-":
//        natija = son1 - son2;
//        break;
//    case "+":
//        natija = son1 + son2;
//        break;
//    default:
//        Console.WriteLine("nomalum belgi kiritdingiz");
//        return;

//}
//Console.WriteLine(natija);




//int natija = 0;
//for (int i = 0; i< 100; i++)
//{
//    if (i % 3 == 0) ;
//    {
//        natija += i;
//    }
//}
//Console.WriteLine(natija);

//int sum = 0;

//for (int i = 0; i < 100; i++)
//{
//    if (i % 2 != 0) 
//    {
//        sum = sum + i;
//    }


//    Console.WriteLine(sum);
//}


//for (int i = 0; i < 20; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//int natija = 0;
//for (int a = 0; a < 100; a++)
//{
//    if (a % 3 == 0 && a % 9 != 0)
//    {
//        natija += a;
//    }
//}
//Console.WriteLine(natija);


//int natija = 0;
//for (int i = 0;i<50; i++)
//{
//    if (i % 2 != 0 )
//    {
//        natija +=(i * i);
//    }
//}
//Console.WriteLine(natija);


//Console.WriteLine("so'z kiriting");
//string matn = Console.ReadLine();
//string natija = "";
//for (int i = matn.Length - 1; i >= 0; i--)
//{
//    natija += matn[i];
//}
//Console.WriteLine(natija);



//string matn = Console.ReadLine();
//string natija = "";
//for (int i=0; i<matn.Length;  i++)
//{
//    Console.Write(matn[i] + "-");
//}


//int son1 = int.Parse(Console.ReadLine());

//int son2 = int.Parse(Console.ReadLine());
//if (son1 > son2)
//{
//    for (int i = son2; i <= son1; i++)
//    {
//        if (i % 2 == 0)
//            Console.WriteLine(i);
//    }
//}
//else
//{
//    for (int i = son1; i <= son2; i++)
//    {
//        if (i % 2 == 0)
//            Console.WriteLine(i);
//    }
//}



//int parol = 0;
//while (parol != 1234)
//{
//    Console.WriteLine("parol kiriting");
//    parol = int.Parse(Console.ReadLine());
//    if (parol != 1234) 
//    {
//        Console.WriteLine("parol noto'g'ri");
//    }
//    Console.WriteLine("parol to'g'ri");
//}



//int son;
//do
//{
//    Console.WriteLine("son kiriting");
//    son = int.Parse(Console.ReadLine());

//    if (son > 0)
//    {
//        for (int i = 0; i <son; i++)
//        {
//            Console.WriteLine(i+",");
//        }
//    }
//    else if (son<0)
//    {
//        for (int i = son; i < 0; i++)
//        {
//            Console.WriteLine(i+","); 
//        }
//    }

//}
//while (son != 0);
//Console.WriteLine("film tugadi");


