using UnityEngine;

public class ProduceBuild : AbstractSystemBuilds
{
    private const string _floor = "Prefabs/Floor";
    private const string _wall = "Prefabs/Wall";
    private const string _roof = "Prefabs/Roof";

    private Transform _transformSpawn;

    public ProduceBuild(Transform transform)
    {
        _transformSpawn = transform;
    }

    public override GameObject CreateGameObjectFloor()
    {
        var floorAccept = Resources.Load<GameObject>(_floor);
        var instantiateFloor = Instantiate(floorAccept, _transformSpawn.position, _transformSpawn.rotation);
        return instantiateFloor;
    }

    public override GameObject CreateGameObjectWall()
    {
        var wallAccept = Resources.Load<GameObject>(_wall);
        var instantiateWall = Instantiate(wallAccept, _transformSpawn.position = new Vector3(_transformSpawn.position.x, _transformSpawn.position.y + 1.5f, _transformSpawn.position.z), _transformSpawn.rotation);
        return instantiateWall;
    }

    public override GameObject CreateGameObjectRoof()
    {
        var roofAccept = Resources.Load<GameObject>(_roof);
        var instanceRoof = Instantiate(roofAccept, _transformSpawn.position, _transformSpawn.rotation);
        return instanceRoof;
    }
}
