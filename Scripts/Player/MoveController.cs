using UnityEngine;

public class MoveController : MonoBehaviour, IController
{
    [SerializeField]
    [Range(3, 15)]
    private float _speed;

    [SerializeField]
    private Transform _targetTransform;

    private const string _horizontal = "Horizontal";
    private const string _vertical = "Vertical";

    public void MovePlayer()
    {
        float horizontal = Input.GetAxisRaw(_horizontal);
        float vertical = Input.GetAxisRaw(_vertical);
        Vector3 moveForward = _targetTransform.forward * vertical * _speed * Time.deltaTime +
            _targetTransform.right * horizontal * _speed * Time.deltaTime;
        transform.Translate(moveForward);
    }
}
