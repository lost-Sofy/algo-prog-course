Console.WriteLine();
Console.WriteLine("Конвертер температуры");

double celsius = 18.4;
const int changeFarin = 32;
const double changeKel = 273.15;

double tempFarin = (celsius * 9 / 5) + 32;
double tempKel = celsius + changeKel;

Console.WriteLine($"{celsius}°C = {tempFarin}°F = {tempKel}°K");