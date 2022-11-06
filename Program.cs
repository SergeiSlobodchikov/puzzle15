string[,] field = new string[4, 4]
{
    { "1" , "2" , "3" , "4"  },
    { "5" , "6" , "7" , "8"  },
    { "9" , "10", "11", "12" },
    {"13" , "14", "15", " "  },
};
string[,] win = new string[4, 4]
{
    { "1" , "2" , "3" , "4"  },
    { "5" , "6" , "7" , "8"  },
    { "9" , "10", "11", "12" },
    {"13" , "14", "15", " "  },
};
void ShowField()
{
    Console.WriteLine();
    Console.WriteLine(string.Format("  {0,2:0.0} | {1,2:0.0} | {2,2:0.0} | {3,2:0.0}", field[0, 0], field[0, 1], field[0, 2], field[0, 3]));
    Console.WriteLine(" ----+----+----+----");
    Console.WriteLine(string.Format("  {0,2:0.0} | {1,2:0.0} | {2,2:0.0} | {3,2:0.0}", field[1, 0], field[1, 1], field[1, 2], field[1, 3]));
    Console.WriteLine(" ----+----+----+----");
    Console.WriteLine(string.Format("  {0,2:0.0} | {1,2:0.0} | {2,2:0.0} | {3,2:0.0}", field[2, 0], field[2, 1], field[2, 2], field[2, 3]));
    Console.WriteLine(" ----+----+----+----");
    Console.WriteLine(string.Format("  {0,2:0.0} | {1,2:0.0} | {2,2:0.0} | {3,2:0.0}", field[3, 0], field[3, 1], field[3, 2], field[3, 3]));
    Console.WriteLine();
}
int CoordinateX = 3;
int CoordinateY = 3;
Random random = new Random();
int z = random.Next(4, 50);
bool winner = false;

void UP(ref int CoordinateY, int CoordinateX)
{
    if (CoordinateY > 0)
    {
        int x1 = CoordinateX;
        int y1 = CoordinateY - 1;
        proverka(ref x1, ref y1);
        CoordinateY = y1;
        if (CoordinateY > 0)
        {
            CoordinateY = y1;
        }
    }
}

void Down(ref int CoordinateY, int CoordinateX)
{
    if (CoordinateY < 3)
    {
        int x1 = CoordinateX;
        int y1 = CoordinateY + 1;
        proverka(ref x1, ref y1);
        CoordinateY = y1;
        if (CoordinateY < 3)
        {
            CoordinateY = y1;
        }
    }
}

void Left(int CoordinateY, ref int CoordinateX)
{
    if (CoordinateX > 0)
    {
        int x1 = CoordinateX - 1;
        int y1 = CoordinateY;
        proverka(ref x1, ref y1);
        CoordinateY = y1;
        if (CoordinateY >= 0)
        {
            CoordinateX = x1;
        }
    }
}

void Right(int CoordinateY, ref int CoordinateX)
{
    if (CoordinateX < 3)
    {
        int x1 = CoordinateX + 1;
        int y1 = CoordinateY;
        proverka(ref x1, ref y1);
        CoordinateY = y1;
        if (CoordinateX <= 3)
        {
            CoordinateX = x1;
        }
    }
}

for (int q = 0; q < z; q++)
{

    for (int i = 0; i < 3; i++)
    {
        UP(ref CoordinateY, CoordinateX);

    }
    for (int i = 0; i < 3; i++)
    {
        Left(CoordinateY, ref CoordinateX);

    }
    for (int i = 0; i < 3; i++)
    {
        Down(ref CoordinateY, CoordinateX);

    }
    for (int i = 0; i < 3; i++)
    {
        Right(CoordinateY, ref CoordinateX);
    }
   
    for (int i = 0; i < 2; i++)
    {
        UP(ref CoordinateY, CoordinateX);

    }
  
    for (int i = 0; i < 3; i++)
    {
        Left(CoordinateY, ref CoordinateX);

    }
   
    for (int i = 0; i < 1; i++)
    {
        Down(ref CoordinateY, CoordinateX);

    }
    
    for (int i = 0; i < 3; i++)
    {
        Right(CoordinateY, ref CoordinateX);
    }
   
    for (int i = 0; i < 3; i++)
    {
        Down(ref CoordinateY, CoordinateX);

    }
     
     for (int i = 0; i < 1; i++)
    {
        Left(CoordinateY, ref CoordinateX);

    }
    

}

for (int i = 0; i < 20; i++)
{
    z = random.Next(5);
    int z1 = random.Next(4);
    if (z == 1)
    {
        for (int q = 0; q < z1; q++)
        {
            UP(ref CoordinateY, CoordinateX);
        }
    }
    if (z == 2)
    {
        for (int q = 0; q < z1; q++)
        {
            Left(CoordinateY, ref CoordinateX);
        }
    }
    if (z == 3)
    {
        for (int q = 0; q < z1; q++)
        {
            Down(ref CoordinateY, CoordinateX);
        }
    }
    if (z == 4)
    {
        for (int q = 0; q < z1; q++)
        {
            Right(CoordinateY, ref CoordinateX);
        }
    }

}

while(field[3,3] != " " )
        {
        Down(ref CoordinateY, CoordinateX);
        Right(CoordinateY, ref CoordinateX);
        }


ShowField();
void proverka(ref int x1, ref int y1)
{
    for (int x = 0; x < 4; x++)
    {
        for (int y = 0; y < 4; y++)
        {
            if (field[y, x] == " ")
            {
                string value = field[y, x];
                field[y, x] = field[y1, x1];
                field[y1, x1] = value;
            }
        }
    }
}

void KeyPressed(ConsoleKeyInfo key, ref string[,] field, ref int CoordinateY, ref int CoordinateX)
{
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            if (CoordinateY > 0)
            {
              UP(ref CoordinateY, CoordinateX);
            }
            break;

        case ConsoleKey.DownArrow:
            if (CoordinateY < 3)
            {
                Down(ref CoordinateY, CoordinateX);
            }
            break;

        case ConsoleKey.LeftArrow:
            if (CoordinateX > 0)
            {
                Left(CoordinateY, ref CoordinateX);
            }
            break;

        case ConsoleKey.RightArrow:
            if (CoordinateX < 3)
            {
                Right(CoordinateY, ref CoordinateX);
            }
            break;

    }
}

while (winner == false)
{
    KeyPressed(Console.ReadKey(), ref field, ref CoordinateX, ref CoordinateY);
    Console.Clear();
    ShowField();
    Console.WriteLine($"{CoordinateX} {CoordinateY}");
    winner = (field[0, 0] == win[0, 0] && field[0, 1] == win[0, 1] && field[0, 2] == win[0, 2] && field[0, 3] == win[0, 3] &&
              field[1, 0] == win[1, 0] && field[1, 1] == win[1, 1] && field[1, 2] == win[1, 2] && field[1, 3] == win[1, 3] &&
              field[2, 0] == win[2, 0] && field[2, 1] == win[2, 1] && field[2, 2] == win[2, 2] && field[2, 3] == win[2, 3] &&
              field[3, 0] == win[3, 0] && field[3, 1] == win[3, 1] && field[3, 2] == win[3, 2] && field[3, 3] == win[3, 3]);
}

Console.WriteLine("Конец игры");
Console.ReadKey();

