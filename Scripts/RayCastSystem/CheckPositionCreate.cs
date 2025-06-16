using UnityEngine;

public class CheckPositionCreate : MonoBehaviour
{
    public void StandNewPosition(RaycastHit hit, Transform pointBuild)
    {
        pointBuild.position = hit.collider.transform.position;
        Debug.Log($"{pointBuild.position}");
    }
}
