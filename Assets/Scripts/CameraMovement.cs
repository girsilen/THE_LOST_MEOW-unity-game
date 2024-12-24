using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 _offset;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;

    
    
    void Start()
    {
        _offset = transform.position - target.position;
    }

    void LateUpdate() 
    {
        var targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }

}