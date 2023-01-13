using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Color_Change : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer =GetComponent<Renderer>();


    }//Start

    // Update is called once per frame
    void Update()
    {
        ColorChenger();

    }//Update

    private void ColorChenger()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _renderer.material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _renderer.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            _renderer.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _renderer.material.color = Color.yellow;
        }
    }//ColorChenger
}
