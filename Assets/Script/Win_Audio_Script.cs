using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Audio_Script : MonoBehaviour
{
    private AudioSource _winSound;
    // Start is called before the first frame update
    void Start()
    {
        _winSound = GetComponent<AudioSource>();
        _winSound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            _winSound.Play();
        }
    }
}
