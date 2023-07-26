/*
Задача 3
Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.

Пример 1:
Входная строка: s = "()"
Результат: true

Пример 2:
Входная строка: s = "()[]{}"
Результат: true

Пример 3:
Входная строка: s = "(]"
Результат: false

Пример 4:
Входная строка: s = "()[]{()}"
Результат: true
*/


using System.Data;
using Microsoft.VisualBasic.CompilerServices;

Dictionary<char, Brackets> elements = new Dictionary<char, Brackets>();
char[] OpenEls = new[] { '[', '{', '(' };
char[] CloseEls = new[] { ']', '}', ')' };

Stack<char> elementsStack = new Stack<char>();


foreach (var openEl in OpenEls)
    elements.Add(openEl, new Brackets() { NumOpened = 0, NumClosed = 0, Type = openEl });

foreach (var closeEl in CloseEls)
    elements.Add(closeEl, new Brackets() { NumOpened = 0, NumClosed = 0, Type = closeEl });


Console.WriteLine("Введите исходную строку:");
//string str = Console.ReadLine();
//string str = "[]{}(){[]}(())[[{}]]";
string str = "[]{}(){[]}(())[{[{}]}]";



bool result = true;

for (int i = 0; i < str.Length; i++)
{
    if (elements.ContainsKey(str[i]) && OpenEls.Contains(str[i]))
        result = UpdateValueInDictionary(elements, str[i], true);
    
    if (elements.ContainsKey(str[i]) && CloseEls.Contains(str[i]))
        result = UpdateValueInDictionary(elements, str[i], false);
}

foreach (var element in elements)
    Console.WriteLine($"EL - {element.Key}. Open = {element.Value.NumOpened}. Close = {element.Value.NumClosed}");

if (result)
    Console.WriteLine($"Результат анализа строки = {AnalizeElement(elements)}");
else
    Console.WriteLine($"Была ошибка в следовании ковычек.");








bool UpdateValueInDictionary(Dictionary<char, Brackets> elements, char type, bool OpenClose)
{
    bool res = true;
    if (elements.TryGetValue(type, out var currEl))
    {
        if (OpenClose)
            currEl.IncreaseOpened();
        else
        {
            currEl.IncreaseClosed();

            if (currEl.NumClosed > elements[ReturnClosed(type)].NumOpened)
            {
                Console.WriteLine($"Ошибка следований скобок. Закрывается, но при этом не открывалась.");
                res = false;
            }
        }
        elements[type] = currEl;
    }

    return res;
}







bool AnalizeElement(Dictionary<char, Brackets> elements)
{
    if (elements['['].NumOpened == elements[']'].NumClosed &&
        elements['{'].NumOpened == elements['}'].NumClosed &&
        elements['('].NumOpened == elements[')'].NumClosed ) 
        return true;
    else
        return false;
}







char ReturnClosed(char input)
{
    switch (input)
    {
        case ']':
            return '[';
        case '}':
            return '{';
        case ')':
            return '(';
    }
    return ' ';
}

bool CheckOpenClose(char open, char close)
{
    bool res = false;
    if (open == '[' && close == ']') res = true;
    if (open == '{' && close == '}') res = true;
    if (open == '(' && close == ')') res = true;
    return res;
}


struct Brackets
{
    public char Type { get; set; }

    public int NumOpened { get; set; }

    public int NumClosed { get; set; }

    public void IncreaseOpened()
    {
        NumOpened++;
    }

    public void IncreaseClosed()
    {
        NumClosed++;
    }

}