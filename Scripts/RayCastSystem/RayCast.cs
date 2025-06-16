using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private GameObject _pointRayGameObject;

    [SerializeField]
    private Transform _pointRay;

    private const string _acceptBuild = "Ground";
    private const string _build = "Build";
    private const string _checkNavigation = "CheckNavigation";

    private const float _distanceRay = 10f;

    private CheckPositionCreate _checkPositionCreate = new CheckPositionCreate();

    private void LateUpdate()
    {
        RayCastSystem();
    }

    private void RayCastSystem()
    {
        Debug.DrawRay(_mainCamera.transform.position, _pointRay.transform.forward * 20, Color.red);
        Ray ray = _mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        GetInfoTransform(_pointRay.position.normalized);

        if (Physics.Raycast(ray, out hit, _distanceRay, LayerMask.GetMask(_acceptBuild, _build, _checkNavigation)))
        {
            if (LayerMask.LayerToName(hit.collider.gameObject.layer) == _checkNavigation && PatternSingleton.Instance.buildFloor == true)
            {
                Debug.Log("Проверка земли");
                PatternSingleton.Instance.buildRoof = false;
                PatternSingleton.Instance.buildWall = false;
                _checkPositionCreate.StandNewPosition(hit, _pointRay);
            }
            else if (LayerMask.LayerToName(hit.collider.gameObject.layer) == _build && PatternSingleton.Instance.buildWall == true)
            {
                Debug.Log("Проверка дома");
                PatternSingleton.Instance.buildFloor = false;
                _checkPositionCreate.StandNewPosition(hit, _pointRay);
            }
            else if (LayerMask.LayerToName(hit.collider.gameObject.layer) == _checkNavigation && PatternSingleton.Instance.buildRoof == true)
            {
                Debug.Log("Проверка второго этажа");
                PatternSingleton.Instance.buildFloor = false;
                PatternSingleton.Instance.buildWall = false;
                _checkPositionCreate.StandNewPosition(hit, _pointRay);
            }
            else if (LayerMask.LayerToName(hit.collider.gameObject.layer) == _acceptBuild)
            {
                Debug.Log("Проверка пола");
                PatternSingleton.Instance.buildBool = true;
                BuildStartFloor(hit);
            }
        }
    }

    private void GetInfoTransform(Vector3 position)
    {
        position = _pointRayGameObject.transform.position;
    }

    private void BuildStartFloor(RaycastHit hit)
    {
        Debug.Log(hit.transform.tag + hit.transform.position);
        _pointRay.position = hit.point;
        GetInfoTransform(_pointRayGameObject.transform.position);
    }
}
