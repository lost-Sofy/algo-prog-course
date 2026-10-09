// string myName = "Егорова Софья";
// string groupName = "ИСП-252";
// int courseNumber = 2;
// double averageGrade = 4.5;
// bool isBudget = true;

// Console.WriteLine("Знакомство");
// Console.WriteLine($"Студент: {myName}");
// Console.WriteLine($"Группа: {groupName}");
// Console.WriteLine($"Курс: {courseNumber}");
// Console.WriteLine($"Средний балл: {averageGrade}");
// Console.WriteLine($"Бюджетное место: {isBudget}");

// Console.WriteLine();
// Console.WriteLine("Ремонт: комната");

// double roomWight = 3.5;
// double roomLength = 4.2;

// double roomArea = roomWight * roomLength;
// double roomPerimeter = (roomWight + roomLength) * 2;

// Console.WriteLine($"Ширина: {roomWight} м, длина: {roomLength} м");
// Console.WriteLine($"Площадь: {roomArea} кв.м");
// Console.WriteLine($"Периметр: {roomPerimeter} м");

// Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 65000;
// int monthsCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthlyPayment = totalWithInterest / monthsCount;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// Console.WriteLine($"Платеж в месяц: {monthlyPayment} руб.");

// Console.WriteLine();
// Console.WriteLine("ВНимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;

// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount; 

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstName = "Софья";
string lastName = "Егорова";

// Способ Конкатенации через "+"
string fullNameConcat = firstName + " " + lastName;

// Способ интерполяции через $""
string fullNameInterp = $"{firstName} {lastName}";

// Метод string.Concat
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}"); // Проверяет равны ли строковые переменные

Console.WriteLine();
Console.WriteLine("Константы");

// Сохраняет значение, которое нельзя изменить
const double VatRate = 0.20; 
const string CollegeName = "Вф ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate); // Сохраняет и рассчитывает стоимость с учетом НДС

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}): {priceWithVat}");

int scholarship = 1435;
int monthlyExpenses = 1100;
const int MonthsInSemester = 4;

Console.WriteLine($"Остаток стипендии к концу месяца: {scholarship - monthlyExpenses}");
Console.WriteLine($"Затраты за семестр: {monthlyExpenses * 4}");
Console.WriteLine($"Остаток за семестр: {(scholarship - monthlyExpenses) * 4}");