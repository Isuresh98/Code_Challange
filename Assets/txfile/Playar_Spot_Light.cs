using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playar_Spot_Light : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;

    private Rigidbody _rbody;
    private Vector3 _velocityPoint;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Light _Spot1;

    

    
    // Start is called before the first frame update
    void Start()
    {

        _rbody = GetComponent<Rigidbody>();
        _renderer =GetComponent<Renderer>();
      _Spot1.enabled=false;

    }//Start

    // Update is called once per frame
    void Update()
    {
       Movement();



    }//Update

    void Movement()
    {
         _horizontal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        _velocityPoint = _rbody.velocity;
        _velocityPoint.x = _horizontal;
        _velocityPoint.z = _vertical;
        _rbody.velocity = _velocityPoint;


    }//Movement

  void OnCollisionEnter(Collision collect)
  {
    if(collect.gameObject.CompareTag("Point"))
    {
            _renderer.material.color = Color.green;

    }

  }//OnCollisionEnter

void OnTriggerEnter(Collider Colect)
{
  if(Colect.gameObject.CompareTag("Point"))
  {
_Spot1.enabled=true;

  }
}//OnTriggerEnter
void OnTriggerExit(Collider Colect)
{
  if(Colect.gameObject.CompareTag("Point"))
  {
_Spot1.enabled=false;

  }


}//OnTriggerExit


}//Class

