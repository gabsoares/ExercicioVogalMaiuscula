char[] palavra = new char[10];

for (int i = 0; i < 10; i++)
{
    palavra[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
    {
        switch (palavra[i])
        {
            case 'a':
                palavra[i] = 'A';
                break;
            case 'e':
                palavra[i] = 'E';
                break;
            case 'i':
                palavra[i] = 'I';
                break;
            case 'o':
                palavra[i] = 'O';
                break;
            case 'u':
                palavra[i] = 'U';
                break;
            default:
                Console.WriteLine("Não é vogal");
                break;
        }
    }
    Console.Write(palavra[i]);
}