namespace AOC_2016
{
    public class Day12
    {
        public static int PartOne(string[] input)
        {
            var regA = 0;
            var regB = 0;
            var regC = 0;
            var regD = 0;
            for (int i = 0; i < input.Length;)
            {
                if (input[i].StartsWith("cpy"))
                {
                    int val = 0;
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": val = regA; break;
                        case "b": val = regB; break;
                        case "c": val = regC; break;
                        case "d": val = regD; break;
                        default: val = int.Parse(input[i].Split(" ")[1]); break;
                    }
                    switch (input[i].Split(" ")[2])
                    {
                        case "a": regA = val; break;
                        case "b": regB = val; break;
                        case "c": regC = val; break;
                        case "d": regD = val; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("inc"))
                {
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": regA++; break;
                        case "b": regB++; break;
                        case "c": regC++; break;
                        case "d": regD++; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("dec"))
                {
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": regA--; break;
                        case "b": regB--; break;
                        case "c": regC--; break;
                        case "d": regD--; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("jnz"))
                {
                    bool jnz = true;
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": jnz = regA == 0; break;
                        case "b": jnz = regB == 0; break;
                        case "c": jnz = regC == 0; break;
                        case "d": jnz = regD == 0; break;
                        default: jnz = int.Parse(input[i].Split(" ")[1]) == 0; break;
                    }
                    if (!jnz)
                    {
                        i += int.Parse(input[i].Split(" ")[2]);
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return regA;
        }

        public static int PartTwo(string[] input)
        {
            var regA = 0;
            var regB = 0;
            var regC = 1;
            var regD = 0;
            for (int i = 0; i < input.Length;)
            {
                if (input[i].StartsWith("cpy"))
                {
                    int val = 0;
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": val = regA; break;
                        case "b": val = regB; break;
                        case "c": val = regC; break;
                        case "d": val = regD; break;
                        default: val = int.Parse(input[i].Split(" ")[1]); break;
                    }
                    switch (input[i].Split(" ")[2])
                    {
                        case "a": regA = val; break;
                        case "b": regB = val; break;
                        case "c": regC = val; break;
                        case "d": regD = val; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("inc"))
                {
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": regA++; break;
                        case "b": regB++; break;
                        case "c": regC++; break;
                        case "d": regD++; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("dec"))
                {
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": regA--; break;
                        case "b": regB--; break;
                        case "c": regC--; break;
                        case "d": regD--; break;
                    }
                    i++;
                }
                else if (input[i].StartsWith("jnz"))
                {
                    bool jnz = true;
                    switch (input[i].Split(" ")[1])
                    {
                        case "a": jnz = regA == 0; break;
                        case "b": jnz = regB == 0; break;
                        case "c": jnz = regC == 0; break;
                        case "d": jnz = regD == 0; break;
                        default: jnz = int.Parse(input[i].Split(" ")[1]) == 0; break;
                    }
                    if (!jnz)
                    {
                        i += int.Parse(input[i].Split(" ")[2]);
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return regA;
        }
    }
}

