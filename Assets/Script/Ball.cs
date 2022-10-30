using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public Vector3 Position => rb.position;

    [SerializeField] Vector3 lastPosition;

    public bool isMoving => rb.velocity != Vector3.zero;
    public bool IsTeleporting => isTeleporting;

    bool isTeleporting;

    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
            
        }
        lastPosition = this.transform.position;
    }

    internal void AddForce(Vector3 force)
    {
        rb.isKinematic = false;
        lastPosition = this.transform.position;
        rb.AddForce(force, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        if(rb.velocity != Vector3.zero && rb.velocity.magnitude < 0.5f)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Out")
        {
            StopAllCoroutines();
            StartCoroutine(DelayedTeleport());
        }
    }

    IEnumerator DelayedTeleport()
    {
        isTeleporting = true;
        yield return new WaitForSeconds(3);
        rb.isKinematic = true;
        this.transform.position = lastPosition;
        isTeleporting = false;
    }
}
