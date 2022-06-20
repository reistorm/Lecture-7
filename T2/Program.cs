// С помощью рекурсии обход разных структур
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                  0   1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1) // обход с помощью позиции pos 
{
    if (pos < tree.Length) // чтобы не вылетело за количество позиций
    {
        int left = 2 * pos; // позиция левого поддерева - 2
        int right = 2 * pos + 1; // позиция правого поддерева - 2*i +1
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если левое поддерево существует и его позиция не является пустой, то запускаем рекурсивно обход дерева с этой позиции
        Console.WriteLine(tree[pos]); // выводим значение
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // аналогично как с левым
    }
}
InOrderTraversal();
// прямой, центрированный и обратный обход бывают
