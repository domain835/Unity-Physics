using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.gameObject.name == "Sphere")
        {
            Debug.Log("Object passed trough the door");
        }
    }
}
