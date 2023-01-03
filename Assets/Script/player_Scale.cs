using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Scale : MonoBehaviour
{
    [SerializeField] private float _scaleAmount;
    
    // Update is called once per frame
    void Update()
    {
        Scale();

    }//Update

    private void Scale()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.localScale = new Vector3(_scaleAmount, _scaleAmount, _scaleAmount);
        }
    }
}
