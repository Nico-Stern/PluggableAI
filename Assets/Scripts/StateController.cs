using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class StateController : MonoBehaviour
{
    public LayerMask Player;
    
    public float speed = 10f;
    public float fastSpeed = 15f;
    public float Sichtweite =3f;
    [HideInInspector]
    public bool collisionThisFrame;

    

    public GameObject left;
    public GameObject right;
    

    public Rigidbody2D rb;

    public State initialState;
    private State currentState;

    [HideInInspector]
    public float currentTimer;
    
    private void Start()
    {
        currentState = initialState;
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void TransitionToState(State targetState)
    {
        if (targetState == null || targetState == currentState) return;

        currentTimer = 0;
        
        currentState = targetState;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Hin"))
        collisionThisFrame = true;
    }

    private void FixedUpdate()
    {
        collisionThisFrame = false;
    }
}
