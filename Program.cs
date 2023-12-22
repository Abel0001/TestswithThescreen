using ScreenLib;

class Program
{
    public static Screen screen = new Screen(30,30);
    private static void Main(string[] args){
        Console.OutputEncoding = System.Text.Encoding.UTF8;    
        screen.InitScreen();

        Selector();
        }

        public static void Selector(){
            char input = Console.ReadKey().KeyChar;

            switch (input){
                case '1':
                PushToGoal.StartGame();
                break;
            }
        }


}