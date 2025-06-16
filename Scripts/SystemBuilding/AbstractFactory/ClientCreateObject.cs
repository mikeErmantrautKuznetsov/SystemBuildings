using UnityEngine;

public class ClientCreateObject : MonoBehaviour
{
    [SerializeField]
    private Transform _objectPointTransform;

    private AbstractSystemBuilds _abstractSystemBuilds;

    private void Update()
    {
        ControllerCreateFloor();
        ControllerCreateWall();
        ControllerCreateRoof();
        TurnObject();
    }

    private void ControllerCreateFloor()
    {
        if (Input.GetMouseButtonDown(0) 
            && PatternSingleton.Instance.buildBool == true 
            && PatternSingleton.Instance.buildFloor == true
            && PatternSingleton.Instance.buildRoof == false)
        {
            CreateFloor();
        }
    }

    private void ControllerCreateWall()
    {
        if (Input.GetMouseButtonDown(0) 
            && PatternSingleton.Instance.buildBool == true
            && PatternSingleton.Instance.buildWall == true
            && PatternSingleton.Instance.buildRoof == false)
        {   
            CreateWall();
        }
    }
    
    private void ControllerCreateRoof()
    {
        if (Input.GetMouseButtonDown(0) 
            && PatternSingleton.Instance.buildBool == true
            && PatternSingleton.Instance.buildWall == false
            && PatternSingleton.Instance.buildRoof == true)
        {
            CreateRoof();
        }
    }

    public void TurnObject()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _objectPointTransform.transform.Rotate(_objectPointTransform.transform.rotation.x, 90f, _objectPointTransform.transform.rotation.z);
        }
    }

    private void CreateWall()
    {
        _abstractSystemBuilds = new ProduceBuild(_objectPointTransform);
        _abstractSystemBuilds.CreateGameObjectWall();
    }

    private void CreateFloor()
    {
        _abstractSystemBuilds = new ProduceBuild(_objectPointTransform);
        _abstractSystemBuilds.CreateGameObjectFloor();
    }

    private void CreateRoof()
    {
        _abstractSystemBuilds = new ProduceBuild(_objectPointTransform);
        _abstractSystemBuilds.CreateGameObjectRoof();
    }
}
