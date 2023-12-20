public class GameObject{
    int[] position = new int[2];
    Screen screen;
    string NameId{get;}
    int lockedListPosition;
    int State{
        get; set;
    }

    public GameObject(string name, Screen occupiedScreen, int stateId){
        NameId = name;
        screen = occupiedScreen;
        State = stateId;
    }

    public void Summon(int x, int y){
        if((screen.ySize - 1) * (screen.xSize - 1) < x * y) return;
        position[0] = x;
        position[1] = y;
        screen.LockedList.Add(screen.GetCorrespondingINum(x,y));
        lockedListPosition = screen.LockedList.Count - 1;
        screen.ChangeCharacter(x,y,State);
    }

    public bool isValidPosition(int x, int y){
        return (y < screen.ySize) && (x >= 0 && y >= 0) && (x % screen.xSize != 0 || x == 0);

    }

    public void Move(int x, int y){
        
        if(!isValidPosition(position[0] + x, position[1] + y)) return;
        position[0] += x;
        position[1] += y;
        screen.LockedList[lockedListPosition] = screen.GetCorrespondingINum(position[0],position[1]);
        screen.ChangeCharacter(position[0],position[1], State);
        screen.ClearScreen();
        screen.RenderScreen();
    }

    public void Move(int[] coords){
        if(!isValidPosition(coords[0] + position[0], coords[1] + position[1])) return;
        position[0] += coords[0];
        position[1] += coords[1];
        screen.LockedList[lockedListPosition] = screen.GetCorrespondingINum( position[0],position[1]);
        screen.ChangeCharacter(position[0],position[1], State);
        screen.ClearScreen();
        screen.RenderScreen();
    }

}