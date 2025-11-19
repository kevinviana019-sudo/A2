using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected CharacterController controller;
    protected Vector3 velocity;

    protected virtual void Start()
    {
        controller = GetComponent<CharacterController>();
    }
}
