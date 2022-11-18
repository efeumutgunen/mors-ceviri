using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(32768)));

            System.Media.SoundPlayer shortmorse = new System.Media.SoundPlayer(@"Sounds\shortmorse.wav");
            System.Media.SoundPlayer longmorse  = new System.Media.SoundPlayer(@"Sounds\longmorse.wav");

            string yazitxttomors, yazimorstotxt, morsharfkontrol = "", ceviri = "", cevirimorstotext = "", sesliOkumaText, version = "v1.2";
            char eh, ehmtt, ehanamenusecim, ehanamenusecimf, ehSeslendirmeIslem, ehanamenusecimSesliOkuma;
            int secim;

        ikisecim:
            cevirimorstotext = "";
            ceviri = "";
            Console.Clear();
            Console.WriteLine("Mors Çeviri Programı {0}", version);
            Console.WriteLine("------------------------------");

            Console.WriteLine("(1) Mors yazısını yazısına dönüştürme.");
            Console.WriteLine("(2) Yazıyı mors yazısına dönüştürme.");
            Console.WriteLine("(3) Mors yazısını sesli okuma.");
            Console.WriteLine("(4) Çıkış.");
            Console.WriteLine("");
            Console.Write("Seçim: ");

            try
            {
                secim = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                goto ikisecim;
            }

            Console.Clear();

            switch (secim)
            {
                case 1:
                programbasimorstotext:
                    ceviri = "";
                    cevirimorstotext = "";
                    
                    Console.WriteLine("Mors yazısını yazıya dönüştürme.");
                    Console.WriteLine("------------------------------------------");

                    Console.Write("Dönüşmesini istediğiniz mors yazısını giriniz: ");
                    yazimorstotxt = Console.ReadLine();

                    yazimorstotxt = yazimorstotxt + " ";

                    char[] morsayrim = new char[yazimorstotxt.Length];

                    for (int c = 0; c < yazimorstotxt.Length; c++)
                    {
                        morsayrim[c] = yazimorstotxt[c];

                        morsharfkontrol = morsharfkontrol + morsayrim[c];

                        if (morsayrim[c] == ' ')
                        {
                            #region SwitchCaseMorsToText
                            switch (morsharfkontrol)
                            {
                                case ".- ":
                                    cevirimorstotext = cevirimorstotext + "A";
                                    morsharfkontrol = "";
                                    break;

                                case "-... ":
                                    cevirimorstotext = cevirimorstotext + "B";
                                    morsharfkontrol = "";
                                    break;

                                case "-.-. ":
                                    cevirimorstotext = cevirimorstotext + "C";
                                    morsharfkontrol = "";
                                    break;

                                case "-.-.. ":
                                    cevirimorstotext = cevirimorstotext + "Ç";
                                    morsharfkontrol = "";
                                    break;

                                case "-.. ":
                                    cevirimorstotext = cevirimorstotext + "D";
                                    morsharfkontrol = "";
                                    break;

                                case ". ":
                                    cevirimorstotext = cevirimorstotext + "E";
                                    morsharfkontrol = "";
                                    break;

                                case "..-. ":
                                    cevirimorstotext = cevirimorstotext + "F";
                                    morsharfkontrol = "";
                                    break;

                                case "--. ":
                                    cevirimorstotext = cevirimorstotext + "G";
                                    morsharfkontrol = "";
                                    break;

                                case "--.-. ":
                                    cevirimorstotext = cevirimorstotext + "Ğ";
                                    morsharfkontrol = "";
                                    break;

                                case ".... ":
                                    cevirimorstotext = cevirimorstotext + "H";
                                    morsharfkontrol = "";
                                    break;

                                case ".-..- ":
                                    cevirimorstotext = cevirimorstotext + "İ";
                                    morsharfkontrol = "";
                                    break;

                                case ".. ":
                                    cevirimorstotext = cevirimorstotext + "I";
                                    morsharfkontrol = "";
                                    break;

                                case ".--- ":
                                    cevirimorstotext = cevirimorstotext + "J";
                                    morsharfkontrol = "";
                                    break;

                                case "-.- ":
                                    cevirimorstotext = cevirimorstotext + "K";
                                    morsharfkontrol = "";
                                    break;

                                case ".-.. ":
                                    cevirimorstotext = cevirimorstotext + "L";
                                    morsharfkontrol = "";
                                    break;

                                case "-- ":
                                    cevirimorstotext = cevirimorstotext + "M";
                                    morsharfkontrol = "";
                                    break;

                                case "-. ":
                                    cevirimorstotext = cevirimorstotext + "N";
                                    morsharfkontrol = "";
                                    break;

                                case "--- ":
                                    cevirimorstotext = cevirimorstotext + "O";
                                    morsharfkontrol = "";
                                    break;

                                case "---. ":
                                    cevirimorstotext = cevirimorstotext + "Ö";
                                    morsharfkontrol = "";
                                    break;

                                case ".--. ":
                                    cevirimorstotext = cevirimorstotext + "P";
                                    morsharfkontrol = "";
                                    break;

                                case ".-. ":
                                    cevirimorstotext = cevirimorstotext + "R";
                                    morsharfkontrol = "";
                                    break;

                                case "... ":
                                    cevirimorstotext = cevirimorstotext + "S";
                                    morsharfkontrol = "";
                                    break;

                                case ".--.. ":
                                    cevirimorstotext = cevirimorstotext + "Ş";
                                    morsharfkontrol = "";
                                    break;

                                case "- ":
                                    cevirimorstotext = cevirimorstotext + "T";
                                    morsharfkontrol = "";
                                    break;

                                case "..- ":
                                    cevirimorstotext = cevirimorstotext + "U";
                                    morsharfkontrol = "";
                                    break;

                                case "..-- ":
                                    cevirimorstotext = cevirimorstotext + "Ü";
                                    morsharfkontrol = "";
                                    break;

                                case "...- ":
                                    cevirimorstotext = cevirimorstotext + "V";
                                    morsharfkontrol = "";
                                    break;

                                case ".-- ":
                                    cevirimorstotext = cevirimorstotext + "W";
                                    morsharfkontrol = "";
                                    break;

                                case "-.-- ":
                                    cevirimorstotext = cevirimorstotext + "Y";
                                    morsharfkontrol = "";
                                    break;

                                case "--.. ":
                                    cevirimorstotext = cevirimorstotext + "Z";
                                    morsharfkontrol = "";
                                    break;

                                case "----- ":
                                    cevirimorstotext = cevirimorstotext + "0";
                                    morsharfkontrol = "";
                                    break;

                                case ".---- ":
                                    cevirimorstotext = cevirimorstotext + "1";
                                    morsharfkontrol = "";
                                    break;

                                case "..--- ":
                                    cevirimorstotext = cevirimorstotext + "2";
                                    morsharfkontrol = "";
                                    break;

                                case "...-- ":
                                    cevirimorstotext = cevirimorstotext + "3";
                                    morsharfkontrol = "";
                                    break;

                                case "....- ":
                                    cevirimorstotext = cevirimorstotext + "4";
                                    morsharfkontrol = "";
                                    break;

                                case "..... ":
                                    cevirimorstotext = cevirimorstotext + "5";
                                    morsharfkontrol = "";
                                    break;

                                case "-.... ":
                                    cevirimorstotext = cevirimorstotext + "6";
                                    morsharfkontrol = "";
                                    break;

                                case "--... ":
                                    cevirimorstotext = cevirimorstotext + "7";
                                    morsharfkontrol = "";
                                    break;

                                case "---.. ":
                                    cevirimorstotext = cevirimorstotext + "8";
                                    morsharfkontrol = "";
                                    break;

                                case "----. ":
                                    cevirimorstotext = cevirimorstotext + "9";
                                    morsharfkontrol = "";
                                    break;

                                case ".-.-.- ":
                                    cevirimorstotext = cevirimorstotext + ".";
                                    morsharfkontrol = "";
                                    break;

                                case "--..-- ":
                                    cevirimorstotext = cevirimorstotext + ",";
                                    morsharfkontrol = "";
                                    break;

                                case "-.-.-- ":
                                    cevirimorstotext = cevirimorstotext + "!";
                                    morsharfkontrol = "";
                                    break;

                                case "..--.. ":
                                    cevirimorstotext = cevirimorstotext + "?";
                                    morsharfkontrol = "";
                                    break;

                                case "/ ":
                                    cevirimorstotext = cevirimorstotext + " ";
                                    morsharfkontrol = "";
                                    break;

                                default:
                                    cevirimorstotext = cevirimorstotext + "#";
                                    morsharfkontrol = "";
                                    break;
                            }
                            #endregion
                        }
                    }
                    Console.Write("Çeviri:");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(cevirimorstotext);
                    Console.ForegroundColor = ConsoleColor.Gray;

                yenidencevirimorstotext:

                    Console.Write("Yeniden çeviri yapmak ister misiniz? (E/H): ");

                    try
                    {
                        ehmtt = Convert.ToChar(Console.ReadLine().ToUpper());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                        goto yenidencevirimorstotext;
                    }

                    if (ehmtt == 'E')
                    {
                        Console.Clear();
                        cevirimorstotext = "";
                        goto programbasimorstotext;
                    }
                    else if (ehmtt == 'H')
                    {
                    anamenudonus0:
                        Console.Write("Ana menüye geri dönmek ister misiniz (E/H): ");
                        try
                        {
                            ehanamenusecimf = Convert.ToChar(Console.ReadLine().ToUpper());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                            goto anamenudonus0;
                        }
                        if (ehanamenusecimf == 'E')
                        {
                            Console.Clear();
                            goto ikisecim;
                        }
                        else if (ehanamenusecimf == 'H')
                        {

                        }
                        else
                        {
                            Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                            goto anamenudonus0;
                        }

                    }
                    else
                    {
                        Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                        goto yenidencevirimorstotext;
                    }

                    break;

                case 2:
                programbasitexttobase:
                    ceviri = "";
                    cevirimorstotext = "";
                    Console.WriteLine("Yazıyı mors yazısına dönüştürme.");
                    Console.WriteLine("------------------------------------------");

                    Console.Write("Dönüşmesini istediğiniz yazıyı giriniz: ");
                    yazitxttomors = Console.ReadLine().ToUpper();

                    char[] metinayrim = new char[yazitxttomors.Length];

                    for (int x = 0; x < yazitxttomors.Length; x++)
                    {
                        metinayrim[x] = yazitxttomors[x];
                        #region SwitchCaseTextToMors

                        switch (metinayrim[x])
                        {
                            case 'A':
                                ceviri = ceviri + ".- ";
                                break;

                            case 'B':
                                ceviri = ceviri + "-... ";
                                break;

                            case 'C':
                                ceviri = ceviri + "-.-. ";
                                break;

                            case 'Ç':
                                ceviri = ceviri + "-.-.. ";
                                break;

                            case 'D':
                                ceviri = ceviri + "-.. ";
                                break;

                            case 'E':
                                ceviri = ceviri + ". ";
                                break;

                            case 'F':
                                ceviri = ceviri + "..-. ";
                                break;

                            case 'G':
                                ceviri = ceviri + "--. ";
                                break;

                            case 'Ğ':
                                ceviri = ceviri + "--.-. ";
                                break;

                            case 'H':
                                ceviri = ceviri + ".... ";
                                break;

                            case 'İ':
                                ceviri = ceviri + ".-..- ";
                                break;

                            case 'I':
                                ceviri = ceviri + ".. ";
                                break;

                            case 'J':
                                ceviri = ceviri + ".--- ";
                                break;

                            case 'K':
                                ceviri = ceviri + "-.- ";
                                break;

                            case 'L':
                                ceviri = ceviri + ".-.. ";
                                break;

                            case 'M':
                                ceviri = ceviri + "-- ";
                                break;

                            case 'N':
                                ceviri = ceviri + "-. ";
                                break;

                            case 'O':
                                ceviri = ceviri + "--- ";
                                break;

                            case 'Ö':
                                ceviri = ceviri + "---. ";
                                break;

                            case 'P':
                                ceviri = ceviri + ".--. ";
                                break;

                            case 'R':
                                ceviri = ceviri + ".-. ";
                                break;

                            case 'S':
                                ceviri = ceviri + "... ";
                                break;

                            case 'Ş':
                                ceviri = ceviri + ".--.. ";
                                break;

                            case 'T':
                                ceviri = ceviri + "- ";
                                break;

                            case 'U':
                                ceviri = ceviri + "..- ";
                                break;

                            case 'Ü':
                                ceviri = ceviri + "..-- ";
                                break;

                            case 'V':
                                ceviri = ceviri + "...- ";
                                break;

                            case 'W':
                                ceviri = ceviri + ".-- ";
                                break;

                            case 'Y':
                                ceviri = ceviri + "-.-- ";
                                break;

                            case 'Z':
                                ceviri = ceviri + "--.. ";
                                break;

                            case '0':
                                ceviri = ceviri + "----- ";
                                break;

                            case '1':
                                ceviri = ceviri + ".---- ";
                                break;

                            case '2':
                                ceviri = ceviri + "..--- ";
                                break;

                            case '3':
                                ceviri = ceviri + "...-- ";
                                break;

                            case '4':
                                ceviri = ceviri + "....- ";
                                break;

                            case '5':
                                ceviri = ceviri + "..... ";
                                break;

                            case '6':
                                ceviri = ceviri + "-.... ";
                                break;

                            case '7':
                                ceviri = ceviri + "--... ";
                                break;

                            case '8':
                                ceviri = ceviri + "---.. ";
                                break;

                            case '9':
                                ceviri = ceviri + "----. ";
                                break;

                            case '.':
                                ceviri = ceviri + ".-.-.- ";
                                break;

                            case ',':
                                ceviri = ceviri + "--..-- ";
                                break;

                            case '!':
                                ceviri = ceviri + "-.-.-- ";
                                break;

                            case '?':
                                ceviri = ceviri + "..--.. ";
                                break;

                            case ' ':
                                ceviri = ceviri + "/ ";
                                break;

                            default:
                                ceviri = ceviri + "# ";
                                break;
                        #endregion
                        }
                    }

                    Console.Write("Çeviri:");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ceviri);
                    Console.ForegroundColor = ConsoleColor.Gray;

                yenidenceviri:

                    Console.Write("Yeniden çeviri yapmak ister misiniz? (E/H): ");

                    try
                    {
                        eh = Convert.ToChar(Console.ReadLine().ToUpper());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                        goto yenidenceviri;
                    }

                    if (eh == 'E')
                    {
                        Console.Clear();
                        goto programbasitexttobase;
                    }
                    else if (eh == 'H')
                    {
                    anamenudonus1:
                            Console.Write("Ana menüye geri dönmek ister misiniz (E/H): ");
                            try
                            {
                                ehanamenusecim = Convert.ToChar(Console.ReadLine().ToUpper());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                                goto anamenudonus1;
                            }
                            if (ehanamenusecim == 'E')
                            {
                                Console.Clear();
                                goto ikisecim;
                            }
                            else if (ehanamenusecim == 'H')
                            {

                            }
                            else
                            {
                                Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                                goto anamenudonus1;
                            }
                    }
                    else
                    {
                        Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                        goto yenidenceviri;
                    }
                    break;
                
                case 3:        
            sesliOkumaGoto:
                    Console.WriteLine("Mors yazısını sesli okuma.");
                    Console.WriteLine("------------------------------------------");
                
                    Console.Write("Sesli okumasını istediğiniz mors yazısını giriniz:");
                    sesliOkumaText = Console.ReadLine();
                   
                    char[] morseplayerchar = new char[sesliOkumaText.Length];

                    for (int ForMorsePlay = 0; ForMorsePlay < sesliOkumaText.Length; ForMorsePlay++)
                    {
                        morseplayerchar[ForMorsePlay] = sesliOkumaText[ForMorsePlay];

                        switch (morseplayerchar[ForMorsePlay])
                        { 
                            case '.':
                                shortmorse.Play();
                                Thread.Sleep(200);
                                break;

                             case '-':
                                 longmorse.Play();
                                 Thread.Sleep(400);
                                 break;

                             case ' ':
                                 Thread.Sleep(300);
                                 break;

                             case '/':
                                 Thread.Sleep(400);
                                 break;

                                    default: break;
                        }
                     }
            sesliOkumaSoruGoto:
                     Console.Write("Yeniden seslendirmek ister misin? (E/H): ");
                     try
                     {
                         ehSeslendirmeIslem = Convert.ToChar(Console.ReadLine().ToUpper());
                     }
                     catch (FormatException)
                     {
                         Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                         goto sesliOkumaSoruGoto;
                     }

                     if (ehSeslendirmeIslem == 'E')
                     {
                        Console.Clear();
                        goto sesliOkumaGoto;
                     }
                     else if (ehSeslendirmeIslem == 'H')
                     {

                     }
                     else
                     {
                         Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                         goto sesliOkumaSoruGoto;
                     }

                     if (ehSeslendirmeIslem == 'H')
                     {
                     anamenudonusSesliOkuma:
                         Console.Write("Ana menüye geri dönmek ister misiniz (E/H): ");
                         try
                         {
                             ehanamenusecimSesliOkuma = Convert.ToChar(Console.ReadLine().ToUpper());
                         }
                         catch (FormatException)
                         {
                             Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                             goto anamenudonusSesliOkuma;
                         }
                         if (ehanamenusecimSesliOkuma == 'E')
                         {
                             Console.Clear();
                             goto ikisecim;
                         }
                         else if (ehanamenusecimSesliOkuma == 'H')
                         {

                         }
                         else
                         {
                             Console.WriteLine("HATA: E ve H'den başka cevap girilemez.");
                             goto anamenudonusSesliOkuma;
                         }
                     }
                            break;

                case 4:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("HATA: Sadece 1, 2, 3 ve 4 ile seçim yapabilirsiniz.");
                    goto ikisecim;
            }
        }
    }
}