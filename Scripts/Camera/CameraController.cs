using UnityEngine;

public class CameraController : MonoBehaviour, ICameraController
{
    private const string _mouseX = "Mouse X";
    private const string _mouseY = "Mouse Y";

    public void CameraRotate()
    {
        float mouseY = Input.GetAxis(_mouseX);
        float mouseX = Input.GetAxis(_mouseY);
        Vector3 rotateValue = new Vector3(mouseX, -mouseY, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}
