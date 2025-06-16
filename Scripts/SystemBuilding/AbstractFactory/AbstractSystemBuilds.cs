using UnityEngine;

public abstract class AbstractSystemBuilds : MonoBehaviour
{
    public abstract GameObject CreateGameObjectFloor();
    public abstract GameObject CreateGameObjectWall();
    public abstract GameObject CreateGameObjectRoof();
}
