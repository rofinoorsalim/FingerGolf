using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool isEntered = false;

    public bool Entered { get => isEntered; }

    private void OnTriggerEnter(Collider other)
    {
        isEntered = true;
    }
}
