using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotetion : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    [SerializeField] private float _scaleAmmount=3f;



    // Update is called once per frame
    void Update()
    {
        Rotetion();

    }

    private void Rotetion()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Rotate(Vector3.down * _speed * Time.deltaTime);
            transform.localScale = new Vector3(_scaleAmmount, _scaleAmmount, _scaleAmmount);

        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
          transform.Rotate(Vector3.up * _speed * Time.deltaTime);
           


        }

    }//Rotetion
}
