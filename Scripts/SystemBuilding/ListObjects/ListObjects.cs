using System.Collections.Generic;
using UnityEngine;

public class ListObjects : MonoBehaviour
{
    private Dictionary<ListType, List<GameObject>> _buildObject = new Dictionary<ListType, List<GameObject>>();

    public void AddListObject(ListType key, GameObject buildObject)
    {
        TryAddListObject(key, buildObject);
        Debug.Log($"Список пополнен: key: {key}. object: {buildObject.name}.");
    }

    public void TryAddListObject(ListType key, GameObject buildObject)
    {
        if (!_buildObject.ContainsKey(key))
        {
            _buildObject.Add(key, new List<GameObject>());
        }
        _buildObject[key].Add(buildObject);
    }

    public void RemoveListObject(ListType key)
    {
        List<GameObject> gameObject = _buildObject[key];
        Destroy(gameObject[(int)key]);
        _buildObject.Remove(key);
        Debug.Log($"Объект {gameObject} уничтожен");
    }

    public void ClearList()
    {
        _buildObject.Clear();
    }
}
