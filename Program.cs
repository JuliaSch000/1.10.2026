using System.Net.NetworkInformation;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("+-----------------------+");
Console.WriteLine("|\tWIZYTÓWKA\t|");
Console.WriteLine("+-----------------------+");
Console.WriteLine("|Imię: Lena\t\t|");
Console.WriteLine("|Wiek: 19\t\t|");
Console.WriteLine("|Gra: Stardew Valley\t|");
Console.Write("+-----------------------+");




Console.WriteLine("nazwa bohatera");
string NEWNAME = Console.ReadLine()!;
Console.WriteLine("nazwa krainy");
string NEWPLACE = Console.ReadLine()!;
Console.WriteLine("ile dni wyprawy");
int NEWDAYS = int.Parse(Console.ReadLine()!);
Console.WriteLine("ile zlota");
decimal GOLD = decimal.Parse(Console.ReadLine()!);

Console.WriteLine($"Jestem {NEWNAME}.\nMieszkam w miejscu zwanym {NEWPLACE}. Podróżowałem już {NEWDAYS} dni, I mam {GOLD} złota. ");









Console.WriteLine("ile masz atk");
int ATK = int.Parse(Console.ReadLine()!);

Console.WriteLine("jaka silna jest broń");
int BRON = int.Parse(Console.ReadLine()!);

int ATKNORMAL = ATK + BRON;
int ATKCRIT = ATKNORMAL * 2;
Console.WriteLine($"ATAK:\n{ATKNORMAL}\nCRIT:\n{ATKCRIT}\n");















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