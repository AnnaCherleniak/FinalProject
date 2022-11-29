string[] text = {"Hello","World","!",":-)"};
int n = 3; //максимальная длина элемента
int count = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i].Length <= n) count++;
}
string[] text2 = new string[count];
int j = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i].Length <= n)
    {
        text2[j] = text[i];
        j++;
    }
}
for(int i = 0; i < text2.Length; i++)
    Console.Write($"{text2[i]} ");
Console.WriteLine();