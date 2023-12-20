public class PushToGoal
{   
    static ObjectList objectList = new ObjectList(Program.screen);
    static GameObject player = new GameObject("Player", Program.screen, 1, objectList, true, true);
    static GameObject box = new GameObject("Box", Program.screen, 1, objectList, true, false);
    static PushableObject pushBox = new PushableObject("Push", Program.screen, 1, objectList, true, false);


    public static void StartGame(){
        player.Summon(5,5);
        
        box.Summon(7,7);
        pushBox.Summon(9,9);
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