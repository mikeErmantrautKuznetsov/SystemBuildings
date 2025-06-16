using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private float _transparency = 0.5f;

    private Material _material;
    private Color _buildingColor;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        _buildingColor = _material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        _material.color = new Color(_buildingColor.g, _buildingColor.r, _buildingColor.r, _transparency);
        Debug.Log("Красный");
    }

    private void OnTriggerExit(Collider other)
    {
        _material.color = new Color(_buildingColor.r, _buildingColor.g, _buildingColor.b, _transparency);
        Debug.Log("Зеленый");
    }
}
