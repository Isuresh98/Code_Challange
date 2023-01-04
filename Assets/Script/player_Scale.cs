using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Scale : MonoBehaviour
{
    [SerializeField] private float _scaleAmount;
    [SerializeField] private Renderer _renderer;
  



    private void Start()
    {
           _renderer = GetComponent<Renderer>();

    }//Start

    // Update is called once per frame
    void Update()
    {
        Scale();
        Color();

    }//Update

    private void Color()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            _renderer.material.color = UnityEngine.Color.red;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {

            _renderer.material.color = UnityEngine.Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {

            _renderer.material.color = UnityEngine.Color.green;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {

            _renderer.material.color = UnityEngine.Color.yellow;
        }
    }//Color

    private void Scale()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.localScale = new Vector3(_scaleAmount, _scaleAmount, _scaleAmount);
        }
    }//Scale
}
