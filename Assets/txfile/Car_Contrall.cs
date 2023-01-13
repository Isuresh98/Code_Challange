using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Contrall : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotetSpeed;

    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;

    private float drix;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    private void Movement()
    {
        _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Rotate(Vector3.up * _horizontal * _rotetSpeed * Time.deltaTime);
        transform.Translate(0f, 0f, _vertical * _speed * Time.deltaTime);
    }
}
