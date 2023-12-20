using System.Globalization;

class PushableObject : GameObject
{
  
    public PushableObject(string name, Screen occupiedScreen, int stateId, ObjectList list, bool canCollide, bool ableToPush) : base(name, occupiedScreen, stateId, list, canCollide, ableToPush)
    {
        isPushable = true;
        NameId = name;
        screen = occupiedScreen;
        State = stateId;
        exists = false;
        objectList = list;
        willCollide = canCollide;

    }

    public void Push(GameObject gameObject){
        if(gameObject.canPush){
            int[] direction = new int[] {gameObject.position[0] - this.position[0], gameObject.position[1] - this.position[1]};

            switch(direction){
                case [1,0]:
                Move(-1,0);
                break;
                case [-1,0]:
                Move(1,0);
                break;
                case [0, 1]:
                Move(0,-1);
                break;
                case [0, -1]:
                Move(0, 1);
                break;
            }
        }
    }

    
}