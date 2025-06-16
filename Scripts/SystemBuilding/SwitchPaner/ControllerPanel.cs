using UnityEngine;

public class ControllerPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelObject;
    [SerializeField]
    private GameObject _pointBuild;

    private ChoiceObjects _choiceObjects;

    private void Start()
    {
        GameObject controllerBuilds = GameObject.FindWithTag("ControllerPanel");
        _choiceObjects = controllerBuilds.GetComponent<ChoiceObjects>();
    }

    private void Update()
    {
        SwitchPanel();
        SwitchNewObject();
    }

    public void SwitchPanel()
    {
        if (Input.GetKeyDown(KeyCode.G) && PatternSingleton.Instance.isActivePanel == false)
        {
            _panelObject.SetActive(false);
            _pointBuild.SetActive(false);
            PatternSingleton.Instance.buildBool = false;
            PatternSingleton.Instance.buildFloor = false;
            PatternSingleton.Instance.buildRoof = false;
            PatternSingleton.Instance.buildWall = false;
            PatternSingleton.Instance.isActivePanel = true;
        }
        else if (Input.GetKeyDown(KeyCode.G) && PatternSingleton.Instance.isActivePanel == true)
        {
            _panelObject.SetActive(true);
            _pointBuild.SetActive(true);
            PatternSingleton.Instance.buildBool = true;
            PatternSingleton.Instance.buildFloor = true;
            PatternSingleton.Instance.buildRoof = true;
            PatternSingleton.Instance.buildWall = true;
            PatternSingleton.Instance.isActivePanel = false;
        }
    }

    public void SwitchNewObject()
    {
        if (PatternSingleton.Instance.isActivePanel == false)
        {
            _choiceObjects.SwitchObjectBuild();
        }
    }
}
