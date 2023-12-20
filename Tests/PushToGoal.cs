public class PushToGoal
{
    static GameObject player = new GameObject("Player", Program.screen, 1);
    public static void StartGame(){
        player.Summon(5,5);
        GameLoop();
    }

    public static void GameLoop(){
        while(true){
            MovePlayer();
        }
    }

    public static void MovePlayer(){
         char input = 'o';
             if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            input = keyInfo.KeyChar;

        }

        switch(input){
            case 'w':
            player.Move(0,-1);
            break;
            case 's':
            player.Move(0, 1);
            break;
            case 'd':
            player.Move(1,0);
            break;
            case 'a':
            player.Move(-1,0);
            break;
        }
    }
}