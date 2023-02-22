

string chr = "abcçdefgğhıijklmnoöprsştuüvyz";

getinput:
Console.Write("\nDoğrusal şifreleme için a anahtarını giriniz:");
short inputa = Convert.ToInt16(Console.ReadLine());
Console.Write("\nDoğrusal şifreleme için b anahtarını giriniz:");
short inputb = Convert.ToInt16(Console.ReadLine());
Console.Write("\nDoğrusal şifreleme için girdi giriniz:");
var text = Console.ReadLine().ToLower().Trim();
Console.WriteLine("\nŞifreleme(1)\nŞifre Çözme(2)");
short process = Convert.ToInt16(Console.ReadLine());
List<char> result = new List<char>();

if (process == 1)
{
    for (int i = 0; i < text.Length; i++)
    {
        foreach (var item in chr)
        {
            if (text[i] == item)
            {
                var index = (inputa * chr.IndexOf(item) + inputb) % chr.Length;
                result.Add(chr[index]);

            }
        }
    }

    Console.Write("\nGirdinin şifrelenmiş hâli: ");
    foreach (var item in result)
    {
        Console.Write(item);
    }
    goto getinput;
}

if (process == 2)
{
    int mters = 1;
    for (int modters = 1; modters < chr.Length; modters++)
    {
        if ((inputa * modters) % chr.Length == 1)
        {
            mters = modters;
            break;
        }
    }
    for (int i = 0; i < text.Length; i++)
    {
        foreach (var chars in chr)
        {
            if (text[i] == chars)
            {
                var charindex = chr.IndexOf(chars);

                if (charindex - inputb < 0)
                {
                    charindex = charindex + chr.Length;
                }

                var index = mters * (charindex - inputb) % chr.Length;
                result.Add(chr[index]);

            }

        }
    }

    Console.Write("\nGirdinin çözülmüş hâli: ");
    foreach (var item in result)
    {
        Console.Write(item);
    }
    goto getinput;
}




