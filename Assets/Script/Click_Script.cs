using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Script : MonoBehaviour
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
            RaycastHit hitobj;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hitobj))
            {
                if (hitobj.collider.gameObject.tag == "Point")
                {
                    Destroy(hitobj.collider.gameObject);
                }
            }
        }
        
    }
}
