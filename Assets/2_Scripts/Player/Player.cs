using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
   // public PlayerRenderer PlayerRenderer { get; private set; }
    public PlayerMovement PlayerMovement { get; private set; }
   
    public Rigidbody Rigidbody { get; private set; }

    public Animator Animator { get; private set; }
    public MeshRenderer MeshRenderer { get; private set; }

    private void Awake()
    {
        //PlayerRenderer = GetComponent<PlayerRenderer>();
        PlayerMovement = GetComponent<PlayerMovement>();

        //PlayerCollection = GetComponentInChildren<PlayerCollection>();

        Rigidbody = GetComponent<Rigidbody>();

        Animator = GetComponentInChildren<Animator>();
        MeshRenderer = GetComponentInChildren<MeshRenderer>();
    }
}
