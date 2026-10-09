Console.WriteLine();
Console.WriteLine("Визитка студента");

string firstName = "Софья";
string lastName = "Егорова";
string patronymic = "Алексеевна";

// Собирает ФИО по частям и сохраняет в переменную fullNameConcat
string fullNameConcat = lastName + " " + firstName + " " + patronymic;

int age = 17;
int course = 2;
string group = "ИСП-252";

// Оценки по трем предметам
int markOne = 4;
int markTwo = 5;
int markThree = 4;

// Высчитывает средний балл при поступлении
double middleMark = (markOne + markTwo + markThree) / 3;

Console.WriteLine($"ФИО: {fullNameConcat}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Средний балл при поступлении: {middleMark}");