using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullat_Script : MonoBehaviour
{
    private Rigidbody _rbody;
    [SerializeField] private float _speed;

    [SerializeField] private GameObject _SpotLOject;
    private Light _spotL_Component;
    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody>();
        _rbody.AddForce(transform.forward * _speed);
        _SpotLOject = GameObject.FindWithTag("Spot1");
        _spotL_Component = _SpotLOject.GetComponent<Light>();
        _spotL_Component.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            _spotL_Component.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            _spotL_Component.enabled = false;

        }

    }
}
