static string IO(string t)
{
    string[] let = t.Split(' ');
    char flet;
    
    for (int i = 0; i < let.Length; i++)
    {
        if (let[i].Length < 2)
        {
            continue;
        }
        flet = let[i][0];

        let[i] = let[i].Remove(0, 1);
        let[i] = let[i] + flet + "ай"; 
    }

    return string.Join(" ", let);
}

string smtxt = Console.ReadLine();
string t = IO(smtxt);

Console.Write(t);