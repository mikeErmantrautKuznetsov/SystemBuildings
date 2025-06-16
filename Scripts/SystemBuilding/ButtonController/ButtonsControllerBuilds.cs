using UnityEngine;

public class ButtonsControllerBuilds : MonoBehaviour
{
    private ChoiceObject _choiceObject = new ChoiceObject();

    private void ControllerModels(ListType key)
    {
        _choiceObject.AddObject((int)key);
    }

    public void ChoiceWall()
    {
        ListType key = ListType.WallBusy;
        PatternSingleton.Instance.buildFloor = false;
        PatternSingleton.Instance.buildRoof = false;
        PatternSingleton.Instance.buildWall = true;
        ControllerModels(key);
        Debug.Log("ActiveWall");
    }

    public void ChoiceFloor()
    {
        ListType key = ListType.FloorBusy;
        PatternSingleton.Instance.buildWall = false;
        PatternSingleton.Instance.buildRoof = false;
        PatternSingleton.Instance.buildFloor = true;
        ControllerModels(key);
    }

    public void ChoiceRoof()
    {
        ListType key = ListType.RoofBusy;
        PatternSingleton.Instance.buildWall = false;
        PatternSingleton.Instance.buildFloor = false;
        PatternSingleton.Instance.buildRoof = true;
        ControllerModels(key);
    }
}
