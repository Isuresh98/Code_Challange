using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotetion : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    

    // Update is called once per frame
    void Update()
    {
        Rotetion();
    }

    private void Rotetion()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * _speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * _speed * Time.deltaTime);

        }
    }//Rotetion
}
