using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Rigidbody[] AffectedRigidbodies;
    public float Impulse;


    void Start()
    {
        Explode();
    }

    private void Explode()
    {
        var explosionEpicenter = transform.position;

        foreach (var affectedRigidbody in AffectedRigidbodies)
        {
            var offset = affectedRigidbody.position - explosionEpicenter;
            var directon = offset.normalized;
            affectedRigidbody.AddForce(directon * Impulse, ForceMode.Impulse);
        }
    }
}
