

public class GameObject{

    ObjectList objectList;

    public bool willCollide = false;

    int[] position = new int[2];
    Screen screen;
    string NameId{get;}
    int lockedListPosition;
    int State{
        get; set;
    }
    public bool exists = false;
    public GameObject(string name, Screen occupiedScreen, int stateId, ObjectList list, bool canCollide){
        NameId = name;
        screen = occupiedScreen;
        State = stateId;
        exists = false;
        objectList = list;
        willCollide = canCollide;
    }

    public void Summon(int x, int y){
        if(!exists){
        if(!isValidPosition(x,y)) return;
        position[0] = x;
        position[1] = y;
        screen.LockedList.Add(screen.GetCorrespondingINum(x,y));
        lockedListPosition = screen.LockedList.Count - 1;
        screen.ChangeCharacter(x,y,State);
        objectList.AddObject(this, screen.GetCorrespondingINum(position[0],position[1]));
        exists = true;
        }
    }

    public bool isValidPosition(int x, int y){
        return (y < screen.ySize) && (x >= 0 && y >= 0) && (x % screen.xSize != 0 || x == 0);

    }

    void ChangeSpot(){
        objectList.ChangeObject(this, screen.GetCorrespondingINum(position[0], position[1]));
    }

    public void Move(int x, int y){
        if(willCollide && objectList.isSpotOccupied(position[0] + x,position[1] + y)) return; 
        if(!isValidPosition(position[0] + x, position[1] + y)) return;
        position[0] += x;
        position[1] += y;
        screen.LockedList[lockedListPosition] = screen.GetCorrespondingINum(position[0],position[1]);
        ChangeSpot();
        screen.ChangeCharacter(position[0],position[1], State);
        screen.ClearScreen();
        screen.RenderScreen();
    }

    public void Move(int[] coords){
        if(willCollide && objectList.isSpotOccupied(coords[0] + position[0], coords[1] + position[1])) return; 

        if(!isValidPosition(coords[0] + position[0], coords[1] + position[1])) return;
        position[0] += coords[0];
        position[1] += coords[1];
        screen.LockedList[lockedListPosition] = screen.GetCorrespondingINum( position[0],position[1]);
        ChangeSpot();
        screen.ChangeCharacter(position[0],position[1], State);
        screen.ClearScreen();
        screen.RenderScreen();
    }




}