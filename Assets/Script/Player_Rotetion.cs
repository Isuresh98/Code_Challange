using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotetion : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;


    // Start is called before the first frame update
    void Start()
    {

    }//Start

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(Vector3.down * _speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * _speed * Time.deltaTime);

        }


    }//Update
}
