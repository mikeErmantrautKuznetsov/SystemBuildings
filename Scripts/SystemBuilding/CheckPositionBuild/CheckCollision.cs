using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PatternSingleton.Instance.buildBool = false;
        Debug.Log("������������� ���������");
    }

    private void OnTriggerExit(Collider other)
    {
        PatternSingleton.Instance.buildBool = true;
        Debug.Log("������������� ���������");
    }
}
