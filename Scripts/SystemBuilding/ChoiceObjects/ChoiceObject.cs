using UnityEngine;

public class ChoiceObject : MonoBehaviour
{
    private ListObjects _listObjects = new ListObjects();

    private const string _floor = "Prefabs/Floor";
    private const string _wall = "Prefabs/Wall";
    private const string _roof = "Prefabs/Roof";

    public void AddObject(int key)
    {
        switch (key)
        {
            case (int)ListType.WallBusy:
                _listObjects.AddListObject((ListType)key, Resources.Load<GameObject>(_floor));
                break;
            case (int)ListType.FloorBusy:
                _listObjects.AddListObject((ListType)key, Resources.Load<GameObject>(_wall));
                break;
            case (int)ListType.RoofBusy:
                _listObjects.AddListObject((ListType)key, Resources.Load<GameObject>(_roof));
                break;
        }
    }
}
