using UnityEngine;

public class ChoiceObjects : MonoBehaviour
{
    private ButtonsControllerBuilds _buttonsControllerBuilds;
    private SaveAcceptBuilds _saveAcceptBuilds;

    private void Start()
    {
        GameObject controllerBuilds = GameObject.FindWithTag("ControllerPanel");
        GameObject pointSaveAcceptBuild = GameObject.FindWithTag("Point");
        _buttonsControllerBuilds = controllerBuilds.GetComponent<ButtonsControllerBuilds>();
        _saveAcceptBuilds = pointSaveAcceptBuild.GetComponent<SaveAcceptBuilds>();
    }

    public void SwitchObjectBuild()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _buttonsControllerBuilds.ChoiceWall();
            _saveAcceptBuilds.ActiveGameObjectWall();
            Debug.Log("ActiveWall 1111");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _buttonsControllerBuilds.ChoiceRoof();
            _saveAcceptBuilds.ActiveGameObjectRoof();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _buttonsControllerBuilds.ChoiceFloor();
            _saveAcceptBuilds.ActiveGameObjectFloor();
        }
    }
}
