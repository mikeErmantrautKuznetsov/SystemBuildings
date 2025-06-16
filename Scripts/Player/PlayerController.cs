using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IController _controller;

    private void Awake()
    {
        _controller = GetComponent<IController>();
    }

    private void Update()
    {
        _controller.MovePlayer();
    }
}
