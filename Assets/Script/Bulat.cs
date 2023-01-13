using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
    private Rigidbody _rBody;
    [SerializeField] private float _speed=100f;
    // Start is called before the first frame update
    void Start()
    {
        _rBody = GetComponent<Rigidbody>();
     _rBody.AddForce(transform.forward * _speed );

    }

    // Update is called once per frame
    void Update()
    {
       


    }
}
