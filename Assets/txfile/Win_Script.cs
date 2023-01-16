using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Script : MonoBehaviour
{
    [SerializeField]
    private AudioSource _winAdo;
    // Start is called before the first frame update
    void Start()
    {
        _winAdo = GetComponent<AudioSource>();
        _winAdo.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            _winAdo.Play();
        }
    }
}
