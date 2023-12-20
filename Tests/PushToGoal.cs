public class PushToGoal
{   
    static ObjectList objectList = new ObjectList(Program.screen);
    static Map1 map1 = new Map1(Program.screen, objectList);
    static GameObject player = new GameObject("Player", Program.screen, 1, objectList, true, true,false,5,5);
   // static GameObject box = new GameObject("Box", Program.screen, 1, objectList, true, false,true, 7,7);
   // static GameObject pushBox = new GameObject("Push", Program.screen, 2, objectList, true, true, true,9,9);


    public static void StartGame(){
        player.Summon();
        map1.LoadMap();
      //  box.Summon();
     //   pushBox.Summon();
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