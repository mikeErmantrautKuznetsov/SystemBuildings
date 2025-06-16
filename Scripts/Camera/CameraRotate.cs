using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private ICameraController _cameraController;

    private void Awake()
    {
        _cameraController = GetComponent<ICameraController>();
    }

    private void Update()
    {
        _cameraController.CameraRotate();
    }
}
