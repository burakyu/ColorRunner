using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
    public PlayerMovement PlayerMovement { get; private set; }
   
    public Rigidbody Rigidbody { get; private set; }

    public Animator Animator { get; private set; }
    public SkinnedMeshRenderer SkinnedMeshRenderer { get; private set; }

    private void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();

        Rigidbody = GetComponent<Rigidbody>();

        Animator = GetComponentInChildren<Animator>();
        SkinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }
}
