using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cotrall : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;

    private Rigidbody _rbody;
    private Vector3 _velocityPoint;

    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        _velocityPoint = _rbody.velocity;
        _velocityPoint.x = _horizontal;
        _velocityPoint.z = _vertical;
        _rbody.velocity = _velocityPoint;


    }//Movement
}
