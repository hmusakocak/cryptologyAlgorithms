
string chr = "abcçdefgğhıijklmnoöprsştuüvyz";

getinput:
Console.Write("\nGirdi giriniz: ");
string input = Console.ReadLine().ToLower().Trim();
Console.WriteLine("\nŞifreleme(1)\nŞifre Çözme(2)");
short process = Convert.ToInt16(Console.ReadLine());

if (process == 1)
{
    if (input.Length == 0)
        goto getinput;

    List<char> newstring = new List<char>();
    for (int i = 0; i < input.Length; i++)
    {
        foreach (var chars in chr)
        {
            if (input[i] == chars)
            {
                var crypted = chr[chr.IndexOf(chars) + 3];
                newstring.Add(crypted);
            }
        }
    }
    Console.Write("\nGirdinin Sezar şirelenmiş hâli: ");
    foreach (var item in newstring)
    {
        Console.Write(item);
    }
    goto getinput;
}


if (process == 2)
{
    if (input.Length == 0)
        goto getinput;

    List<char> newstring = new List<char>();
    for (int i = 0; i < input.Length; i++)
    {
        foreach (var chars in chr)
        {
            if (input[i] == chars)
            {
                var index = chr.IndexOf(chars) - 3;
                if (index <= 0)
                {
                    index = chr.Length + chr.IndexOf(chars)-3;
                }
                var crypted = chr[index];
                newstring.Add(crypted);
            }
        }
    }
    Console.Write("\nGirdinin çözülmüş hâli: ");
    foreach (var item in newstring)
    {
        Console.Write(item);
    }
    goto getinput;
}

