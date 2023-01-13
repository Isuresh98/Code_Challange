using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown_Script : MonoBehaviour
{
    [SerializeField] private GameObject _spownPoint;
    [SerializeField] private GameObject _Prefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Instantiate(_Prefabs, _spownPoint.transform.position, _spownPoint.transform.rotation);
        }
    }// OnCollisionEnter
}
