using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;



Console.WriteLine("+-------------------------------+");
Console.WriteLine("|\tHELLO ADVENTURER 2\t|");
Console.WriteLine("+-------------------------------+");


Console.WriteLine("Jak masz na imię?");
string HA2NAME = Console.ReadLine()!;

Console.WriteLine("Ile masz ATK?");
int HA2ATK = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile masz DEF?");
int HA2DEF = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile masz HP?");
int HA2HP = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile masz ZŁOTA?");
decimal HA2G = decimal.Parse(Console.ReadLine()!);


int HA2MAX = HA2ATK + HA2DEF + HA2HP;
int HA2CRIT = HA2ATK * 2;

Console.WriteLine("+================================+");
Console.WriteLine("|\tADVENTURER\t\t|");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"|NAME:\t\t{HA2NAME} \t\t|");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"|ATK:\t\t{HA2ATK} \t\t|");
Console.WriteLine($"|DEF:\t\t{HA2DEF} \t\t|");
Console.WriteLine($"|HP:\t\t{HA2HP} \t\t|");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"|GOLD:\t\t{HA2G} \t\t|");
Console.WriteLine("+================================+");

Console.WriteLine("+================================+");
Console.WriteLine($"|CRIT.  ATK:\t\t{HA2CRIT}\t|");
Console.WriteLine("+--------------------------------+");
Console.WriteLine($"|TOTAL  POWER:\t\t{HA2MAX}\t|");
Console.WriteLine("+================================+");


Console.WriteLine("\n\n");
Console.WriteLine("+-------------------------------+");
Console.WriteLine("\nKONIEC OSTATNIEGO ZADANIA\n");
Console.WriteLine("+-------------------------------+");
Console.WriteLine("\n\n");


Console.WriteLine("nazwa bohatera");
string NEWNAME = Console.ReadLine()!;
Console.WriteLine("nazwa krainy");
string NEWPLACE = Console.ReadLine()!;
Console.WriteLine("ile dni wyprawy");
int NEWDAYS = int.Parse(Console.ReadLine()!);
Console.WriteLine("ile zlota");
decimal GOLD = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("ile exp?");
int EXP = int.Parse(Console.ReadLine()!);


Console.WriteLine("+-----------------------+");
Console.WriteLine("|\tWIZYTÓWKA\t|");
Console.WriteLine("+-----------------------+");
Console.WriteLine("|Imię: Lena\t\t|");
Console.WriteLine("|Wiek: 19\t\t|");
Console.WriteLine("|Gra: Stardew Valley\t|");
Console.Write("+-----------------------+");




Console.WriteLine($"Jestem {NEWNAME}.\nMieszkam w miejscu zwanym {NEWPLACE}. Podróżowałem już {NEWDAYS} dni i mam {GOLD} złota.\n Mam {EXP} punktów doświadczenia.\n ");
decimal DECDAYS = (decimal) NEWDAYS;
decimal DEXP = (decimal) EXP;
decimal SREDNIA_G = GOLD / DECDAYS;
decimal SREDNIA_E = DEXP / DECDAYS;
Console.WriteLine($"W ciągu dnia zdobywam średnio {SREDNIA_E} doświadczenia i {SREDNIA_G} zlota.");



Console.WriteLine("ile masz atk");
int ATK = int.Parse(Console.ReadLine()!);

Console.WriteLine("jaka silna jest broń");
int BRON = int.Parse(Console.ReadLine()!);

int ATKNORMAL = ATK + BRON;
int ATKCRIT = ATKNORMAL * 2;
Console.WriteLine($"ATAK:\n{ATKNORMAL}\nCRIT:\n{ATKCRIT}\n");
int COMBO = (ATKNORMAL * 3) + ATKCRIT;
Console.WriteLine($"\nTrzykrotny atak i jeden crit:\n{COMBO}\n");









Console.WriteLine("Liczba bohaterów");
int LICZBHT = int.Parse(Console.ReadLine()!);
Console.WriteLine("Liczba monet");
int LICZMNT = int.Parse(Console.ReadLine()!);

int PODZIELONE = LICZMNT / LICZBHT;
int ROZDANE = PODZIELONE * LICZBHT;
int RESZTA = LICZMNT - ROZDANE;
Console.WriteLine($"Każdy dostaje po {PODZIELONE} monet. Ilość monet w grupie bohaterów to {ROZDANE}. Zostały {RESZTA} monety reszty.");































Console.WriteLine("ile sekund");
int SEK = int.Parse(Console.ReadLine()!);
int MIN = SEK / 60;
int REALSEK = SEK % 60;
Console.WriteLine($"To jest {MIN} minut i {REALSEK} sekund.");










Console.WriteLine("Ile kosztuje nocleg");
decimal NOCL = decimal.Parse(Console.ReadLine()!);
Console.WriteLine("Ile nocy zostajesz");
int LICZNOC = int.Parse(Console.ReadLine()!);
decimal KOSZT = NOCL * LICZNOC;
Console.Write($"Koszt wynosi {KOSZT} zł");














Console.Write("Ile chcesz mikstur?");
int MIX = int.Parse(Console.ReadLine()!);
int KR = MIX * 3;
int ZIÓŁ = MIX * 2;
Console.Write($"Potrzebujesz:\n{KR} kryształów\n{ZIÓŁ} ziół\n");




Console.WriteLine("Ile jest kilometrów do celu?");
int KMCEL = int.Parse(Console.ReadLine()!);
Console.Write("A ile pokonujesz każdego dnia?");
int KMDNI = int.Parse(Console.ReadLine()!);
int DNI = KMCEL / KMDNI;
Console.WriteLine($"Pokonasz trasę w {DNI} dni.");



Console.Write("Ile złotych?");
int ZL = int.Parse(Console.ReadLine()!);
Console.Write("Srebrnych?");
int SR = int.Parse(Console.ReadLine()!);
Console.Write("Miedzianych?");
int MD = int.Parse(Console.ReadLine()!);

int ZLTRUE = ZL * 100;
int SRTRUE = SR * 10;

int TOTAL = ZLTRUE + SRTRUE + MD;
Console.WriteLine($"Wartość sakiewki wynosi {TOTAL}.");













Console.Write("Imię?");
string NAME = Console.ReadLine()!;
Console.Write("Kolor?");
string COLOR = Console.ReadLine()!;
Console.WriteLine($"Masz na imię {NAME} i masz {COLOR} kapelusz czy coś takiego idk");