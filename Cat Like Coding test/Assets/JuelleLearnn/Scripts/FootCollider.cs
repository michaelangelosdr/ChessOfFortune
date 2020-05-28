using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        col.gameObject.GetComponent<BoxCollider>().isTrigger = false;

    }


    private void OnTriggerExit(Collider col)
    {
        col.gameObject.GetComponent<BoxCollider>().isTrigger = true;
    }
    
}
