string[,] matrix = 
    {
    {  " ", " ", " ", " ", " ", " "},
    {  " ", " ", " ", " ", " ", " "},
    {  " ", "@", " ", "*", " ", " "},
    {  " ", " ", " ", " ", " ", " "},
    {  " ", " ", " ", " ", " ", " "},
    {  " ", " ", " ", " ", " ", " "}
    };
int x = 1;
int y = 2;
int count = 0;
void WriteArrayMatrix(string[,] matrix)
{
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            Console.Write(matrix[y,x] + " ");
        }
        Console.WriteLine();
    }
}
void WriteCoordinates(int x, int y, int count)
{
    Console.WriteLine($"X = {x}  Y = {y} Count = {count}");
}
int BonusCreator(string[,] matrix, int x, int y,int count)
{
    while(matrix[y,x] == "*")
    {
        count++;
        matrix[y,x] = " ";
        int newCoordBonusY = new Random().Next(0,matrix.GetLength(0));
        int newCoordBonusX = new Random().Next(0,matrix.GetLength(1));
        matrix[newCoordBonusY,newCoordBonusX] = "*";
    }
    return count;
}




void Game(string[,] matrix, int x, int y, int count)
{
    while(true)
    {
        matrix[y,x] = " ";
        ConsoleKeyInfo userKeyTab = Console.ReadKey();
        if(userKeyTab.Key == ConsoleKey.W) y--;
        if(userKeyTab.Key == ConsoleKey.S) y++;
        if(userKeyTab.Key == ConsoleKey.A) x--;
        if(userKeyTab.Key == ConsoleKey.D) x++;
        if(y < 0) y = 0;
        if(x < 0) x = 0;
        if(x > matrix.GetLength(1)-1) x = matrix.GetLength(1)-1;
        if(y > matrix.GetLength(0)-1) y = matrix.GetLength(0)-1;
        count = BonusCreator(matrix,x,y,count);
        matrix[y,x] = "@";
        Console.Clear();
        if(count > 9) Console.WriteLine("Вы набрали 10 очков!!");
        if(count > 19) Console.WriteLine("Вы набрали 20 очков!!");
        if(count > 29) Console.WriteLine("Вы набрали 30 очков!!");
        if(count > 39) Console.WriteLine("Вы набрали 40 очков!!");
        if(count > 49) Console.WriteLine("Вы набрали 50 очков!!");
        WriteArrayMatrix(matrix);
        WriteCoordinates(x,y,count);
    }
}
WriteArrayMatrix(matrix);
Game(matrix,x,y,count);

// x=(b2-b1)/(k1-k2);
// y=(k1*(b2-b1))/(k1-k2)+b1;

