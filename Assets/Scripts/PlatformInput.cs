using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInput : MonoBehaviour
{
    private bool _gyroscopeEnabled;
    private Gyroscope _gyroscope;
    private Rigidbody _rigitbody;

    [SerializeField] private float _speed;

    private void Awake()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _gyroscopeEnabled = EnableGyroscope();
    }

    private void FixedUpdate()
    {
        if (_gyroscopeEnabled)
        {
            transform.rotation = _gyroscope.attitude;
        }
        else
        {
            DedugMove();
        }
    }

    private bool EnableGyroscope()
    {
        if (SystemInfo.supportsGyroscope)
        {
            _gyroscope = Input.gyro;
            _gyroscope.enabled = true;
            return true;
        }
        return false;
    }

    private void DedugMove()
    {
        float movementH = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float movementV = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        float rotationX = transform.rotation.x + movementV;
        if (rotationX >= 1)
            rotationX = 1;
        if (rotationX <= -1)
            rotationX = -1;
        float rotationZ = transform.rotation.z - movementH;
        if (rotationZ >= 1)
            rotationZ = 1;
        if (rotationZ <= -1)
            rotationZ = -1;

        _rigitbody.rotation = new Quaternion(rotationX, _rigitbody.rotation.y, rotationZ, _rigitbody.rotation.w);
    }
}
