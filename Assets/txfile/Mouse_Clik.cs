﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Clik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitOj;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hitOj))
            {
                if(hitOj.collider.gameObject.tag == "Point")
                {
                    Destroy(hitOj.collider.gameObject);

                }



            }


        }


    }
}
