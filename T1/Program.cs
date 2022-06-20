// Перебор слов
// В некотором машинном алфавите имеются четыре
// буквы «а», «и», «с» и «в». Покажите все слова,
// состоящие из T букв, которые можно построить из букв
// этого алфавита

// char[] s = { 'a', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine($"{n++, -5}{s[i]}"); // Для однобуквенных
// }
 
 // для двухбуквенных и более циклов для многобуквенных
char[] s = { 'a', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}"); // Для однобуквенных
    }
}
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[4]); // 4 - количество букв в строке


// Рекурсия в жизни
// Алгоритм обхода директория - т.е. посмотреть все папки и файлы
// Запись видео в папке лекция 6

void CatalogInfo(string path, string indent = "")
{
DirectoryInfo catalogs = new DirectoryInfo(path);
foreach (var currentCatalog in catalogs.GetDirectories())
{
Console.WriteLine($"{indent}{currentCatalog.Name}");
CatalogInfo(currentCatalog.FullName, indent + " ");
}
foreach (var item in catalogs.GetFiles())
{
Console.WriteLine($"{indent}{item.Name}");
}
}
string path = @"/Users/sergejkamaneckij/Projects/HelloCode";
CatalogInfo(path);
