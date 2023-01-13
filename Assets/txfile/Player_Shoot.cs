using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _spowPoint;
    [SerializeField]
    private GameObject _prfabs;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_prfabs, _spowPoint.transform.position, _spowPoint.transform.rotation);

        }
    }
}
