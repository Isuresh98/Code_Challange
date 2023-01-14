using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Contraller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotetSpeed;

    [SerializeField] private float _horizotal;
    [SerializeField] private float _vertical;

    private GameObject _spotLight;

    private GameObject _spownPoint;
    private GameObject _prefabsBall;




    // Start is called before the first frame update
    void Start()
    {

        _spotLight = GameObject.FindWithTag("Spot1");

        _spotLight.SetActive(false);

        _spownPoint = GameObject.FindWithTag("Spown");
        _prefabsBall = GameObject.FindWithTag("Ball");

    }

    // Update is called once per frame
    void Update()
    {

        Movement();

        BreakLight();

    }

    private void BreakLight()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spotLight.SetActive(true);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _spotLight.SetActive(false);

        }
    }//BreakLight

    private void Movement()
    {
        _horizotal = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        _vertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        transform.Translate(0f, 0f, _vertical);
        transform.Rotate(Vector3.up * _horizotal);
    }//Movement

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Instantiate(_prefabsBall, _spownPoint.transform.position, _spownPoint.transform.rotation);
        }
    }

}
