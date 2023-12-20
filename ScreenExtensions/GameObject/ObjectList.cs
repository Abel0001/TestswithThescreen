public class ObjectList{
    Screen screen;
    public ObjectList(Screen currScreen){
        screen = currScreen;
    }

    Dictionary<GameObject, int> objectsAndOccupiedSpots = new Dictionary<GameObject, int>();

    public void AddObject(GameObject gameObject,int occupiedSpot){
        objectsAndOccupiedSpots.Add(gameObject, occupiedSpot);
    }
    public bool isSpotOccupied(int x, int y){
            return objectsAndOccupiedSpots.ContainsValue(screen.GetCorrespondingINum(x,y));
    }
    public void ChangeObject(GameObject gameObject, int newSpot){
        if(objectsAndOccupiedSpots.ContainsKey(gameObject)){
            objectsAndOccupiedSpots[gameObject] = newSpot;
        }
    }
}