using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speedMultiplier;
    private int _defaultSpeed;
    
    void Awake()
    {
           _defaultSpeed = Convert.ToInt32(_speedMultiplier);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log("Oyun başlıyor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * _speedMultiplier;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * _speedMultiplier;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * _speedMultiplier;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * _speedMultiplier;
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speedMultiplier += 2;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speedMultiplier = _defaultSpeed;
        }
    }
    void FixedUpdate()
    {
        
    }
}
