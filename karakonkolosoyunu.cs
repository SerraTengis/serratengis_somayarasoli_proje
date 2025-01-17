using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakonkolosoyunu
{

    internal class Program
    {

        class Game
        {
            // Kullanıcı ismi için özellik
            private string _userName;

            public string UserName
            {
                get { return _userName; }
                set { _userName = value; }
            }

            // Kullanıcı ismini al ve hoş geldin mesajını göster
            public virtual void KullaniciIsminiAl()
            {
                Console.Write("Lütfen isminizi girin: ");
                UserName = Console.ReadLine();
                Console.WriteLine($"Maceraya hazır ol, {UserName}!");
            }
        }


        class AdventureGame : Game
        {
            // Kullanıcıdan ismi tekrar istemeden devam mesajını göster
            public void OyunDevamMesaji()
            {
                Console.WriteLine($"Oyun devam ediyor, {UserName}!");
            }
        }


        static void hatabildirim()
            {
                Console.WriteLine("HATA! tekrar deneyin.");  // Sabit hata mesajını yazdır
            }

            static void Main(string[] args)
            {
                Game game = new Game();
                game.KullaniciIsminiAl();


                {
                    // Başlangıç cümleleri
                    string[] giris = {
            "Evine gelen bir mektupla hiç görmediğin dedenin öldüğünü ve köydeki evinin sana miras kaldığı haberini alıyorsun.",
            "Bir süre sonra ani bir kararla dedenden miras kalan eve taşınıyorsun.",
            "Ev, çevresi ormanla kaplı küçük bir köyün içerisinde ve ocak ayı olduğundan her taraf karlarla örtülü.", "" +
            "                                   /\\\r\n                              /\\  //\\\\\r\n                       /\\    //\\\\///\\\\\\        /\\\r\n                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\\r\n         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\\r\n        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\\r\n       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *\r\n      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\\r\n     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\\r\n    / ^^  ^ ^ ^\\  /______________________________\\ ^ ^ \\ /|o|||\\\r\n   /  ^  ^^ ^ ^  /________________________________\\  ^  /|||||o|\\\r\n  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\\\r\n / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |\r\n/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo\r\nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo",


            "Birkaç gün sonra köyde bir sorun olduğunu fark ediyorsun. Sabah vakitlerinde herkes toplanıp karın erimesi için dua ediyor ve sana yatmadan önce kapını kilitleyip, dışarı çıkmaman gerektiği konusunda uyarılarda bulunuyorlar ama nedenini de söylemiyorlar."
        };


                    // Başlangıç cümlelerini sırasıyla yazdır
                    foreach (var cumle in giris)
                    {
                        Console.WriteLine(cumle);
                        Console.ReadLine();  // Her cümleden sonra kullanıcıdan bir tuşa basmasını bekle
                    }





                    // Seçim seçeneklerini ekrana yazdır
                    Console.WriteLine("\nSeçim yapınız:");
                    Console.WriteLine("1. Köy halkını umursama ve gece kapını kilitleme");
                    Console.WriteLine("2. Köy halkını dinle, gece kapıları ve pencereleri kilitleyerek uyu");

                    // Seçim işlemi
                    char secim;
                    bool gecerliSecim = false;

                    // Geçerli bir seçim yapılana kadar kullanıcıyı yönlendir
                    while (!gecerliSecim)
                    {
                        Console.WriteLine("\nLütfen 1 veya 2 tuşlayınız:");
                        secim = Console.ReadKey(true).KeyChar; // true parametresi, tuşun ekranda görünmesini engeller.

                        // Seçimin geçerli olup olmadığını kontrol et
                        if (secim == '1')
                        {
                            // 1 seçildiğinde kötü son ile oyun sonlanır
                            Console.WriteLine("\nKöy halkına güvenmemeyi tercih ettiniz ve bu seçiminiz ölmenize sebep oldu.");
                            Console.WriteLine("1. Sona ulaştınız. (Kötü Son)");
                            gecerliSecim = true; // Geçerli seçim yapıldı, döngüyü sonlandır
                            Environment.Exit(0); // Oyunu sonlandırır
                        }
                        else if (secim == '2')
                        {
                            // 2 seçildiğinde oyun devam eder
                            Console.WriteLine("\nKöy halkını dinlemeyi tercih ettiniz ve gece güven içinde uyudunuz.");
                            {
                            AdventureGame adventureGame = new AdventureGame
                            {
                                UserName = game.UserName // Kullanıcı adını temel sınıftan aktar
                            };
                            adventureGame.OyunDevamMesaji();
                        
                    }
                            gecerliSecim = true; // Geçerli seçim yapıldı, döngüyü sonlandır
                            OyunDevamEtsin(); // Oyun devam fonksiyonunu çağır
                        }
                        else
                        {
                            // Geçersiz seçim için uyarı

                            // Metod çağırma
                            hatabildirim();  // "HATA! Lütfen tekrar deneyin." mesajı yazdırılır
                            Console.WriteLine("Lütfen sadece 1 veya 2'yi tuşlayınız.");
                        }
                    }
                }
            }



       

        // Oyun devam fonksiyonu
        static void OyunDevamEtsin()
        {
            // Yeni senaryo cümleleri
            string[] devam = {
            "Ne olduğuna anlam veremesen de köy halkını dinliyorsun. Sabah oluyor ve birtakım seslerle uyanıyorsun.",
            "Dışarıya çıktığında köyden birinin gece donarak öldüğü haberini alıyorsun.",
            "Yaklaşık bir yıl önce dedenin de bu köyde donarak öldüğü aklına geliyor. İçinden bunun bir tesadüf olmadığını ve bu işte bir terslik olduğunu düşünüyorsun."
        };

            // Yeni senaryo cümlelerini sırasıyla yazdır
            foreach (var cumle in devam)
            {
                Console.WriteLine(cumle);
                Console.ReadLine();  // Her cümleden sonra kullanıcıdan bir tuşa basmasını bekle
            }






            // Yeni seçim
            Console.WriteLine("\nSeçim yapınız:");
            Console.WriteLine("1. Bu köyün normal olmadığını düşünerek köyü terk etmeye karar veriyorsun.");
            Console.WriteLine("2. Köyde yaşanan ölümler ve köy halkının garip davranışlarının bir bağlantısı olduğunu düşünüyorsun ve bunu çözmeye karar veriyorsun.");

            // Yeni seçim işlemi
            char yeniSecim;
            bool gecerliSecim2 = false;

            while (!gecerliSecim2)
            {
                Console.WriteLine("\nLütfen 1 veya 2 tuşlayınız:");
                yeniSecim = Console.ReadKey(true).KeyChar; // true parametresi, tuşun ekranda görünmesini engeller.

                // Seçimin geçerli olup olmadığını kontrol et
                if (yeniSecim == '1')
                {
                    // 1 seçildiğinde köyü terk etme durumu
                    Console.WriteLine("\nKöyü terk etmeye karar verdiniz ve güvenli bir yere doğru yola çıktınız.");
                    Console.WriteLine("1. Sona ulaştınız. (Köyü terk etme Sonu)");
                    gecerliSecim2 = true; // Geçerli seçim yapıldı, döngüyü sonlandır
                    Environment.Exit(0); // Oyunu sonlandırır
                }
                else if (yeniSecim == '2')
                {
                    // 2 seçildiğinde köydeki gariplikleri çözmeye karar verme
                    Console.WriteLine("\nKöydeki gariplikleri çözmeye karar verdiniz ve araştırmalara başladınız.");
                    Console.WriteLine("Oyun devam ediyor...");
                    OyunDevamEtsin2(); // Oyun devam fonksiyonunu çağır (2. devam fonksiyonu)
                    gecerliSecim2 = true;
                }
                else
                {
                    // Geçersiz seçim için uyarı
                    hatabildirim();  // "HATA! Lütfen tekrar deneyin." mesajı yazdırılır
                    Console.WriteLine("Lütfen sadece 1 veya 2'yi tuşlayınız.");
                }
            }
        }







        // Oyun devam fonksiyonu (ikinci aşama)
        static void OyunDevamEtsin2()
        {
            // Yeni soru - Umay Nine ile konuşma
            Console.WriteLine("\nKöyde yaşananları çözmek için kararlısın ama kimse seninle bu konuda konuşmak istemiyor.");
            Console.ReadLine(); 

            Console.WriteLine("Sorularını sormak üzere köyün yaşlılarından Umay ninenin yanına gidiyorsun.");
            Console.ReadLine(); 

            Console.WriteLine("Umay nine ilk başta seninle konuşmuyor ama bir süre sonra senin kararlılığını görünce sorduğun soruları cevaplamaya karar veriyor.");
            Console.ReadLine();







            // Umay Nine'ye sorular soruluyor
            Console.WriteLine("\nSeçim yapınız:");
            Console.WriteLine("1. Neden gece kapıları kilitliyoruz ve dışarı çıkmıyoruz?");
            Console.WriteLine("2. Dün gece ölen adamla dedemin ölüm şekli aynı, bu bir tesadüf mü?");

            char secim;
            bool gecerliSecim3 = false;

            while (!gecerliSecim3)
            {
                Console.WriteLine("\nLütfen 1 veya 2 tuşlayınız:");
                secim = Console.ReadKey(true).KeyChar; // true parametresi, tuşun ekranda görünmesini engeller.

                // Seçimin geçerli olup olmadığını kontrol et
                if (secim == '1')
                {
                    // 1 seçildiğinde cevap verilir
                    Console.WriteLine("\nUmay nine derin bir iç çekiyor: 'Eğer kapılarımızı kilitlemezsek tıpkı dün gece ölen adam gibi biz de ölebiliriz.'");
                    Console.ReadLine(); // Kullanıcıdan tuşa basmasını bekle

                    Console.WriteLine("\nKafan karışıyor. 'Neden ölebiliriz, hiçbir şey anlamıyorum?' diye soruyorsun.");
                    Console.ReadLine(); // Kullanıcıdan tuşa basmasını bekle

                    Console.WriteLine("\nOyun devam ediyor...");
                    OyunDevamEtsin3(); // Oyun devam fonksiyonu (3. aşama)
                    gecerliSecim3 = true;
                }
                else if (secim == '2')
                {
                    // 2 seçildiğinde cevap verilir
                    Console.WriteLine("\nUmay ninenin gözleri doluyor: 'Bunun bir tesadüf olmasını çok isterdim ama maalesef değil.'");
                    Console.ReadLine(); // Kullanıcıdan tuşa basmasını bekle

                    Console.WriteLine("\nOyun devam ediyor...");
                    OyunDevamEtsin3(); // Oyun devam fonksiyonu (3. aşama)
                    gecerliSecim3 = true;
                }
                else
                {
                    // Geçersiz seçim için uyarı
                    hatabildirim();  // "HATA! Lütfen tekrar deneyin." mesajı yazdırılır
                    Console.WriteLine("Lütfen sadece 1 veya 2'yi tuşlayınız.");
                }
            }
        }







        // Oyun devam fonksiyonu (Üçüncü aşama)
        static void OyunDevamEtsin3()
        {
           

        string[] umayNineHikayesi = {
            "Umay nine anlatmaya başlıyor.",
            "Karakonkolosu hiç duydun mu?",
            "Karakonkolos eski Türk inanışına göre kış mevsiminde ortaya çıkan ve insanlar uyurken onlara sevdikleri kişinin sesiyle seslenerek evden dışarıya çıkartıp soğuktan donmalarını sağlayan mitolojik bir karakterdir.Ve kitaplarda bahsetmeselerde bir görevi daha vardır o da doğanın dengesini sağlayan hayat ağacını korumak.Bunun sadece bir efsane olduğunu ve köyümüzle bir alakası olmadığını düşünebilirsin. Bizler bundan çok uzun yıllar önce atalarımızın yapmış olduğu bir hatanın bedelini ödüyoruz…",
            "Büyük dedemin anlattıklarına göre Atalarımız buraya bir yerleşim alanı oluşturabilmek için ormana zarar vermişler. En önemlisi de hayat ağacını kesmişler.Karakonkolos’un bütün yalvarışlarına rağmen hayat ağacının bütün meyvelerini yemişler ve tekrardan yeşerecek tek bir tohum dahi bırakmamışlar.",
            "Bunu gören Karakonkolos olanca siniriyle “Her yıl ilk kar tanesi düşer düşmez bu köye geleceğim, sizlere ve soyunuzdan gelenlere geceleri en sevdiğiniz kişinin sesiyle seslenip uykunuzda sizi dışarıya çıkaracağım, hayat ağacının tohumları nasıl toprağa gömülüp yeşeremediyse sizde soğuktan donup kara gömüleceksiniz!” Demiş.",
              "                        _,--~~~,\r\n                       .'        `.\r\n                       |           ;\r\n                       |           :\r\n                      /_,-==/     .'\r\n                    /'`\\*  ;      :      \r\n                  :'    `-        :      \r\n                  `~*,'     .     :      \r\n                     :__.,._  `;  :      \r\n                     `\\'    )  '  `,     \r\n                         \\-/  '     )     \r\n                         :'          \\ _\r\n                          `~---,-~    `,)\r\n          ___                   \\     /~`\\\r\n    \\---__ `;~~~-------------~~~(| _-'    `,\r\n  ---, ' \\`-._____     _______.---'         \\\r\n \\--- `~~-`,      ~~~~~~                     `,\r\n\\----      )                                   \\\r\n\\----.  __ /                                    `-\r\n",
            "Umay ninenin sesi titriyor.",
            "Asırlardır her kış kar yağdığında köyümüze gelir, bazılarını dışarı çağırır. Bizde, uyurken kapıdan ya da pencereden dışarı çıkmamak için onları yatmadan önce kilitleriz.Nadirde olsa bazıları uyurken kilidi açmayı başarır ve gece soğuktan donar.",
            "Şaşkınlıkla anlatılanları dinliyorsun. “Peki bana bunu neden daha önce anlatmadınız?”",
            "“Anlattığımız kişiler köyümüzde yaşananlara inanmadı ve bizi deli olmakla suçladı o gün bu gündür kimseye anlatmıyoruz.”",
            "Umay Nineyle konuştuktan sonra içindeki huzursuzluk artıyor. Bu köy, lanetiyle ve gizemiyle seni bir hayli yorgun düşürüyor.Bu köyde kendini güvende hissetmiyorsun o yüzden bu geceyi köyde geçirip yarın sabah erkenden yola çıkmaya ve köyü terk etmeye karar veriyorsun.",
            "Gece kendini derin bir rüyada buluyorsun…",
            "Ormanın derinliklerinde bir açıklıkta, göğe doğru uzanan görkemli bir geyik beliriyor. Boynuzları yıldızlarla süslenmiş gibi parlıyor. Gözlerinden huzur ve bilgelik akıyor. Geyik sana doğru yaklaşıyor ve konuşmaya başlıyor:",
                "  /|       |\\\r\n`__\\\\       //__'\r\n   ||      ||\r\n \\__`\\     |'__/\r\n   `_\\\\   //_'\r\n   _.,:---;,._\r\n   \\_:     :_/\r\n     |@. .@|\r\n     |     |\r\n     ,\\.-./ \\\r\n     ;;`-'   `---__________-----.-.\r\n     ;;;                         \\_\\\r\n     ';;;                         |\r\n      ;    |                      ;\r\n       \\   \\     \\        |      /\r\n        \\_, \\    /        \\     |\\\r\n          |';|  |,,,,,,,,/ \\    \\ \\_\r\n          |  |  |           \\   /   |\r\n          \\  \\  |           |  / \\  |\r\n           | || |           | |   | |\r\n           | || |           | |   | |\r\n           | || |           | |   | |\r\n           |_||_|           |_|   |_|\r\n          /_//_/           /_/   /_/\r\n",
            "\"Bu köy, sadece lanetle değil, umutla da dolu. Atalarının yaptığı hataları düzeltmek senin elinde. Hayat ağacının bir tohumu hâlâ var. Ormanın derinliklerinde saklı.",
            "O tohumun yeşerebilmesi için bir güce, bir dengeye ihtiyacı var.Bu tohumu bulmak ve yeniden yeşertmek için hem köy halkının hem de Karakonkolos’un barışması gerekiyor bunu ancak birlikte başarabilirler, bu barışı sağlayacak kişi ise…",
            "SENSİN!\"","ama eğer kalmak istemiyorsan sana bir şans vereceğim, beni eğer köy tohum karakonkolos oyununda yenersen gitmene izin vereceğim. 3 olan kazanır. Unutma köy tohumları yedi, bu karakonkolosu mahvetti, karakonkolos köyü lanetledi."
            
           
        };
        foreach (var cumle in umayNineHikayesi)
        {
            Console.WriteLine(cumle);
            Console.ReadLine(); 
        }



            Random rand = new Random();

            string[] secimler = new string[] { "köy", "tohum", "karakonkolos" }; // Tüm seçenekleri küçük harf ile tutuyoruz.

            int oyuncuSkor = 0;  // Oyuncunun galibiyet sayısı
            int geyikSkor = 0;   // Geyik'in galibiyet sayısı

            while (true)
            {
                Console.WriteLine("köy, tohum veya karakonkolos seçin:");
                string oyuncusecim = Console.ReadLine().ToLower(); // Kullanıcıdan alınan input'u küçük harfe dönüştürüyoruz.

                // Kullanıcı geçersiz bir seçim yaparsa tekrar denemesi isteniyor
                if (!secimler.Contains(oyuncusecim))
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen köy, tohum veya karakonkolos seçin.");
                    continue;
                }

                string geyiksecim = secimler[rand.Next(secimler.Length)];
                Console.WriteLine($"alageyik seçimi: {geyiksecim}");

                // Oyun sonuçları
                if (oyuncusecim == geyiksecim)
                {
                    Console.WriteLine("Beraberlik!");
                }
                else if (
                    (oyuncusecim == "tohum" && geyiksecim == "karakonkolos") ||
                    (oyuncusecim == "köy" && geyiksecim == "tohum") ||
                    (oyuncusecim == "karakonkolos" && geyiksecim == "köy"))
                {
                    Console.WriteLine("Tebrikler, kazandın!");
                    oyuncuSkor++;  // Oyuncunun galibiyet sayısını artır
                }
                else
                {
                    Console.WriteLine("alageyik kazandı, oyun bitti!");
                    geyikSkor++;   // Geyik'in galibiyet sayısını artır
                }


                // Skorları yazdır
                Console.WriteLine($"Oyuncu Skoru: {oyuncuSkor} - Alageyik Skoru: {geyikSkor}");

                // 3 galibiyet kazanan oyuncu kazanır
                if (oyuncuSkor == 3)
                {
                    Console.WriteLine("Tebrikler! 3 galibiyetle kazandınız! Ama bu köyü böyle bir halde bırakmak istemiyorsunuz ve yardımcı olmak için kalıyorsunuz.");
                    break;
                }
                else if (geyikSkor == 3)
                {
                    Console.WriteLine("Alageyik 3 galibiyetle kazandı, oyun bitti!");
                    break;
                }
            }


            string[] alageyik = { "Rüya birden sona eriyor",
            "Sabah olunca koşarak Umay ninenin yanına gidiyorsun ve rüyanı anlatıyorsun. Umay nine duydukları karşısında şaşırıyor ve heyecanla sana rüyanda gördüğün geyiğin bilgeliğin ve yol göstericiliğin simgesi olan alageyik olduğunu söylüyor.",
            "Artık kaçamazsın, üzerine büyük bir sorumluluk bindi. Çok büyük bir sorumluluk!",
           "Köyü ve Karakonkolosu barıştırıp bu laneti ortadan kaldırmalısın ama bunu nasıl yapacağın hakkında hiçbir fikrin yok.Öncelikle köy ve Karakonkolos hakkında bilgi edinmek için köyde bulunan kütüphaneye gitmeye karar veriyorsun.",
                " ____________________________________________________\r\n  |____________________________________________________|\r\n  | __     __   ____   ___ ||  ____    ____     _  __  |\r\n  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |\r\n  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |\r\n  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |\r\n  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|\r\n  ||_______________________||__________________________|\r\n  | _____________________  ||      __   __  _  __    _ |\r\n  ||=|=|=|=|=|=|=|=|=|=|=| __..\\/ |  |_|  ||#||==|  / /|\r\n  || | | | | | | | | | | |/\\ \\  \\\\|++|=|  || ||==| / / |\r\n  ||_|_|_|_|_|_|_|_|_|_|_/_/\\_.___\\__|_|__||_||__|/_/__|\r\n  |____________________ /\\~()/()~//\\ __________________|\r\n  | __   __    _  _     \\_  (_ .  _/ _    ___     _____|\r\n  ||~~|_|..|__| || |_ _   \\ //\\\\ /  |=|__|~|~|___| | | |\r\n  ||--|+|^^|==|1||2| | |__/\\ __ /\\__| |==|x|x|+|+|=|=|=|\r\n  ||__|_|__|__|_||_|_| /  \\ \\  / /  \\_|__|_|_|_|_|_|_|_|\r\n  |_________________ _/    \\/\\/\\/    \\_ _______________|\r\n  | _____   _   __  |/      \\../      \\|  __   __   ___|\r\n  ||_____|_| |_|##|_||   |   \\/ __|   ||_|==|_|++|_|-|||\r\n  ||______||=|#|--| |\\   \\   o    /   /| |  |~|  | | |||\r\n  ||______||_|_|__|_|_\\   \\  o   /   /_|_|__|_|__|_|_|||\r\n  |_________ __________\\___\\____/___/___________ ______|\r\n  |__    _  /    ________     ______           /| _ _ _|\r\n  |\\ \\  |=|/   //    /| //   /  /  / |        / ||%|%|%|\r\n  | \\/\\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|\r\n__|  \\/\\|/   /(____|/ //                    /  /||~|~|~|__\r\n  |___\\_/   /________//   ________         /  / ||_|_|_|\r\n  |___ /   (|________/   |\\_______\\       /  /| |______|\r\n      /                  \\|________)     /  / | |",
            "Birkaç kitaba göz attıktan sonra kitaplıkta bulunan oldukça eski, üzeri tozlanmış bir kitap dikkatini çekiyor.",
                "    __________________   __________________\r\n.-/|                  \\ /                  |\\-.\r\n||||                   |                   ||||\r\n||||                   |       ~~*~~       ||||\r\n||||    --==*==--      |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |     --==*==--     ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||                   |                   ||||\r\n||||__________________ | __________________||||\r\n||/===================\\|/===================\\||\r\n`--------------------~___~-------------------''",
            "Kitabı dikkatle eline alıyorsun ve açar açmaz yere bir kâğıt düşüyor. Kâğıdı alıp incelemeye başlıyorsun, kağıttaki yazılar daha önce hiç görmediğin bir dilde yazılmış, Oldukça dikkatini çekiyor.",
            "Kısa bir araştırmayla bunun Orhun alfabesiyle yazılmış olduğunu öğreniyorsun ve kâğıttaki yazanları anlayabilmek için Orhun harflerinin, Türkçedeki hangi harflere karşılık geldiğinin bir listesini çıkartıyorsun ve teker teker harfleri yazıyorsun."
            };
            foreach (var cumle in alageyik)
            {
                Console.WriteLine(cumle); 
                Console.ReadLine(); 
            }


           



            // Kağıttaki doğru cümleyi yazdırma kısmı
            Console.WriteLine("\nKağıtta çini çğarımak keer de çü rakakonoksol yazıyor. ");
            
                Console.WriteLine("\nDilin yazılış formu biraz farklı olduğu için anlamlı bir cümle çıkmıyor. Bu nedenle cümleyi düzeltmen gerekiyor.");

                string correctSentence = "çağırmak için üç kere karakonkolos de";

                // Kullanıcı doğru cümleyi yazana kadar döngü
                bool isCorrect = false;

                while (!isCorrect)
                {
                    // Kullanıcıdan cevap al
                    Console.WriteLine("\nLütfen anlamlı bir cümle kurmaya çalışın:");
                    string userInput = Console.ReadLine();

                    // Cümleyi doğrula
                    isCorrect = ValidateSentence(userInput, correctSentence);
                }

                Console.WriteLine("\nTebrikler, doğru cümleyi yazdınız!");

                // Şimdi bir seçim yapması için oyun devam ediyor
                Console.WriteLine("\nŞimdi bir seçim yapman gerekiyor.");

                // Seçenekler
                Console.WriteLine("\n1: Kâğıtta yazanları uygula");
                Console.WriteLine("2: Kâğıtta yazanları uygulama");

                // Kullanıcıdan seçim alınması
                bool isGameOver = false;

                while (!isGameOver)
                {
                    // Kullanıcıdan seçim al
                    Console.Write("\nBir seçenek girin (1 veya 2): ");
                    string userChoice = Console.ReadLine();

                    // Kullanıcının seçimine göre yönlendirme
                    if (userChoice == "1")
                    {
                        // Seçim 1: Kâğıtta yazanları uygula
                        Console.WriteLine("\nSonuç: Cesaretini toplayıp kâğıtta yazanları yapmaya karar veriyorsun. İçinden bir ses bunun çok tehlikeli olduğunu söylüyor, umarım şansın yaver gider ve mantıklı kararlarınla Karakonkolos’u sinirlendirmeden bir anlaşma sağlarsın.");

                    string[] texts = new string[]
                   {
                        "Gece oluyor ve üç defa karakonkolos diye bağırıyorsun.\n" +
                        "Havanın aniden daha fazla soğuduğunu hissediyorsun ve fısıltıya benzer sesler duymaya başlıyorsun.\n" +
                        "Arkana döndüğünde karşında simsiyah ve kocaman bir gölge görüyorsun, yanına Karakonkolos'un geldiğini anlıyorsun.",

                        "Sinirli bir şekilde sana onu neden çağırdığını soruyor.\n" +
                        "Ona köydeki insanların çok üzgün olduğunu ve atalarının yaptığı bir hatanın bedelini ödememeleri gerektiğini anlatıyorsun.\n" +
                        "Ardından ona rüyandan bahsediyorsun."
                   };

                    // Metinleri sırayla yazdırıyoruz
                    foreach (var text in texts)
                    {
                        Console.WriteLine(text);  // Her bir metni sırayla yazdırıyoruz
                        Console.ReadLine(); // Enter tuşuna basılmasını bekliyoruz

                    }



                    // Zar atma kısmı
                    Console.WriteLine("\nKarakonkolos’un sana inanıp inanmaması senin şansına bağlı. Hemen bir zar at. Zar 2'nin üzerinde bir sayı gelirse karakonkolos sana inanacak.");
                    Console.WriteLine("  ____\r\n /\\' .\\    _____\r\n/: \\___\\  / .  /\\\r\n\\' / . / /____/..\\\r\n \\/___/  \\'  '\\  /\r\n          \\'__'\\/");
                    Console.ReadLine();
                        Random random = new Random();
                        int diceRoll = random.Next(1, 7); // 1-6 arasında rastgele bir sayı

                        Console.WriteLine($"Zar sonucu: {diceRoll}");

                        if (diceRoll <= 2)
                        {
                            Console.WriteLine("\nKarakonkolos sana inanmadı ve laneti kaldıramadın.");
                            Console.WriteLine("\nSona ulaştın. (Şanssız Gün)");
                        
                            isGameOver = true;  // Oyun bitiyor
                        }
                        else
                        {
                            Console.WriteLine("\nKarakonkolos sana inandı ve laneti kaldırıp hayat ağacının tohumunu aramayı kabul etti.");
                            Console.WriteLine("bölüm sonu. oynadığınız için teşekkürler");
                     
                            break;
                        }
                    }
                   
                }
            }

            // Cümle doğrulama fonksiyonu
            static bool ValidateSentence(string userInput, string correctSentence)
            {
                // Küçük harf ile karşılaştırma yapmak için her iki cümleyi de küçük harfe çeviriyoruz
                string userInputLower = userInput.ToLower();
                string correctSentenceLower = correctSentence.ToLower();

                // 1. Adım: Cümle doğru yazıldığında
                if (userInputLower == correctSentenceLower)
                {
                    return true;  // Doğru cümleyi yazdılar, döngü sonlanacak
                }

                // Hatalı yazım kontrolü: Her durumda hata mesajı vereceğiz
                Console.WriteLine("\nHatalı yazım!");  // Her türlü hatada aynı mesaj
                return false;  // Hala doğru cümleyi yazmadılar, döngü devam edecek
            }
        }
    }
