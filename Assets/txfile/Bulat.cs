using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
    private Rigidbody _rBody;
   [SerializeField] private GameObject _spotL;
    private Light _SpotLComponent;
    [SerializeField] private float _speed=100f;
    // Start is called before the first frame update
    void Start()
    {
        _rBody = GetComponent<Rigidbody>();
     _rBody.AddForce(transform.forward * _speed );
        _spotL = GameObject.FindWithTag("Spot1");
        _SpotLComponent = _spotL.GetComponent<Light>();
        _SpotLComponent.enabled = false;
        

    }

    // Update is called once per frame
    void Update()
    {
       


    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Point"))
        {
            _SpotLComponent.enabled = true;
            print("hit");
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
            _SpotLComponent.enabled = false;

    }
}
