using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speedMultiplier;
    private int _defaultSpeed;
    
    void Awake()
    {
           _defaultSpeed = Convert.ToInt32(_speedMultiplier);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Debug.Log("Oyun başlıyor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.linearVelocity = transform.forward * _defaultSpeed;
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
