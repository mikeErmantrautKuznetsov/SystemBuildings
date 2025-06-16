using UnityEngine;

public class SaveAcceptBuilds : MonoBehaviour
{
    [SerializeField]
    private GameObject _wallObject;
    [SerializeField]
    private GameObject _floorObject;
    [SerializeField]
    private GameObject _roofObject;

    public void ActiveGameObjectFloor()
    {
        _wallObject.SetActive(false);
        _roofObject.SetActive(false);
        _floorObject.SetActive(true);
    }

    public void ActiveGameObjectWall()
    {
        _wallObject.SetActive(true);
        _floorObject.SetActive(false);
        _roofObject.SetActive(false);
        Debug.Log("ActiveWall");
    }

    public void ActiveGameObjectRoof()
    {
        _wallObject.SetActive(false);
        _floorObject.SetActive(false);
        _roofObject.SetActive(true);
    }
}
