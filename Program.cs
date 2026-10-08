//zadanie 1

/*

string imie = "Natalia";
char symbol ='@';
int poziom = '2';
int zloto = 35;
double waga = 7.5;
bool mapa = true;

Console.WriteLine("=== Ekwipunek ===");
Console.WriteLine($"Imię: {imie}");
Console.WriteLine($"Symbol: {symbol}");
Console.WriteLine($"Poziom: {poziom}");
Console.WriteLine($"Złoto: {zloto}");
Console.WriteLine($"Waga: {waga}");
Console.WriteLine($"Ma mapę: {mapa}");

*/

//zadanie 2

/*

int punktyDos = 15;
int zloto2 = 10;
punktyDos += 25;
punktyDos *= 2;
zloto2 -= 8;
zloto2 = zloto2 + 15;
punktyDos = punktyDos++;

Console.WriteLine($"Doświadczenie: {punktyDos}, Złoto: {zloto2}");

*/

//zadanie 3
/*

Console.WriteLine("Ile racji? ");
double racje = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ile członkow drużyny? ");
int czlonkowie = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile dni wyprawy? ");
int dni = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Na członka drużyny przypada {(racje / czlonkowie):F0} pełnych racji");

Console.WriteLine($"Na członka drużyny przypada {racje % czlonkowie} pełnych racji");

double racjeDziennieD = racje / dni;

Console.WriteLine($"Dziennie przypada {racjeDziennieD:F2} racji drużynie");

double racjeDziennieC = racjeDziennieD / czlonkowie;

Console.WriteLine($"Dziennie przypada {racjeDziennieC:F2} racji na członka");

*/
//zadanie 4

/*

Console.WriteLine("Ile masz życia? (od 0 do 100): ");
int ileZycia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile masz mikstur? ");
int ileMikstur = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy masz klucz? (true albo false): ");
bool czyKlucz = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Czy masz mape? (true albo false): ");
bool czyMapa = bool.Parse(Console.ReadLine()!);


bool zyje = ileZycia > 0;
bool maPelneZdrowie = ileZycia == 100;
bool maZaopatrzenie = ileMikstur > 0;
bool maPrzedmiotNawigacyjny = czyKlucz || czyMapa;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;

Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {!maPelneZdrowie}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");

*/

//zadanie 5

/*

Console.WriteLine("Jak się nazywasz? ");
string imie = Console.ReadLine()!;

Console.WriteLine("Twoje maksymalne punkty życia? ");
double maxZycie = double.Parse(Console.ReadLine()!);

Console.WriteLine("Twoje aktualne punkty zdrowia? ");
int aktualneZycie = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj podstawowe obrażenia twojej broni: ");
int podstObrazenia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj swoją premie do siły: ");
int premiaSily = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj swój mnożnik ataku: ");
double mnoznikAtaku = double.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj liczbę wykonanych ataków: ");
int liczbaAtakow = int.Parse(Console.ReadLine()!);

int obrazeniaAtaku = podstObrazenia + premiaSily;

int obrazeniaSpecial = (int)(obrazeniaAtaku * mnoznikAtaku);

int laczneObrazenia = (obrazeniaAtaku * liczbaAtakow) + obrazeniaSpecial;

double procentZycia = (aktualneZycie / maxZycie) * 100;

bool zyje = aktualneZycie > 0;

bool pelneZdrowie = aktualneZycie == maxZycie;

Console.WriteLine("========== RAPORT Z WALKI ==========");
Console.WriteLine($"Bohater: {imie}");
Console.WriteLine($"Zdrowie: {aktualneZycie}/{maxZycie} ({procentZycia:F2}%)");
Console.WriteLine($"Zwykły atak: {obrazeniaAtaku}");
Console.WriteLine($"Atak specjalny: {obrazeniaSpecial}");
Console.WriteLine($"Łączne zadane obrażenia: {laczneObrazenia}");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Pełne zdrowie: {pelneZdrowie}");

*/

//projekt

Console.WriteLine("Jak się nazywasz? ");
string imie = Console.ReadLine()!;

Console.WriteLine("Jaki jest twój znak? ");
char znak = char.Parse(Console.ReadLine()!);

Console.WriteLine("Twoje maksymalne punkty życia? ");
double maxZycie = double.Parse(Console.ReadLine()!);

Console.WriteLine("Twoje aktualne punkty zdrowia? ");
int aktualneZycie = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj podstawowe obrażenia twojej broni: ");
int podstObrazenia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj swoją premie do siły: ");
int premiaSily = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj swój mnożnik ataku specjanego: ");
double mnoznikAtaku = double.Parse(Console.ReadLine()!);

const int miejscaPlecaka = 10;

Console.WriteLine("Ile masz przy sobie przedmiotów (max 10)? ");
int zajeteMiejsca = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ile posiadasz złota? ");
int ileZlota = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ilu członkow liczy twoja drużyna? ");
int ileDruzyna = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy masz mape? (true albo false): ");
bool czyMapa = bool.Parse(Console.ReadLine()!);

int zlotoDlaOsoby = ileZlota / ileDruzyna;

int ileZostanie = ileZlota % ileDruzyna;

int obrazeniaAtaku = podstObrazenia + premiaSily;

int obrazeniaSpecial = (int)(obrazeniaAtaku * mnoznikAtaku);

double procentZycia = (aktualneZycie / maxZycie) * 100;

bool wymagaLeczenia = aktualneZycie != maxZycie;

bool maMiejsceWPlecaku = zajeteMiejsca < miejscaPlecaka;

bool zyje = aktualneZycie > 0;

bool pelneZdrowie = aktualneZycie == maxZycie;

bool gotowa = maMiejsceWPlecaku && zyje && czyMapa;


Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.WriteLine($"Bohater: {imie} \t\t\t {znak}");
Console.WriteLine("+==========================================+");
Console.WriteLine($"Zdrowie: {aktualneZycie}/{maxZycie} ({procentZycia:F2}%)");
Console.WriteLine($"Siła: {premiaSily}");
Console.WriteLine($"Zwykłe obrażenia: {obrazeniaAtaku}");
Console.WriteLine($"Mnożnik ataku specjlanego: {mnoznikAtaku}");
Console.WriteLine($"Obrażenia ataku specjlanego: {obrazeniaSpecial}");
Console.WriteLine("+==========================================+");
Console.WriteLine($"Plecak: {zajeteMiejsca}/{miejscaPlecaka}");
Console.WriteLine($"Siła: {miejscaPlecaka - zajeteMiejsca}");
Console.WriteLine($"Złoto: {ileZlota}");
Console.WriteLine($"Liczba członków drużyny: {ileDruzyna}");
Console.WriteLine($"Złoto dla jednej osoby: {ileZlota / ileDruzyna}");
Console.WriteLine($"Złoto pozostające w skarbcu: {ileZlota % ileDruzyna}");
Console.WriteLine("+==========================================+");
Console.WriteLine($"Ma mape: {czyMapa}");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {pelneZdrowie}");
Console.WriteLine($"Wymaga leczeia: {wymagaLeczenia}");
Console.WriteLine($"Ma miejsce w plecaku: {maMiejsceWPlecaku}");
Console.WriteLine($"Gotowx do wyprawy: {gotowa}");
Console.WriteLine("+==========================================+");











