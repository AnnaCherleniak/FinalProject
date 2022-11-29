string[] text = {"Hello","World","!",":-)"};
int count = 0;
for(int i = 0; i < text.Length; i++)
{
    if(text[i].Length <= 3) count++;
}
