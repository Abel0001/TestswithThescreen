using System.Security.Cryptography;

public class Map1{
    Screen screen;
    ObjectList objectList;
    public Map1(Screen currScreen, ObjectList objects){
        screen = currScreen;
        objectList = objects;
    }

    public void LoadMap(){
        for(int i = 0; i < 15; i++){
            GameObject gameObject = new GameObject(i.ToString(), screen, RandomNumberGenerator.GetInt32(3), objectList, true, RandomNumberGenerator.GetInt32(2) == 1 ? true : false, RandomNumberGenerator.GetInt32(2) == 1 ? true : false, RandomNumberGenerator.GetInt32(screen.xSize) , RandomNumberGenerator.GetInt32(screen.ySize));
            gameObject.Summon();
        }
    }
}