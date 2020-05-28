using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour
{
    [SerializeField]
    Baselevelcreator creator;

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Base")
        {          
            //other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            creator.CreateNewBase();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
     
        if(other.tag =="Base")
        {
           // other.GetComponent<SpriteRenderer>().enabled = false;
            creator.CreateNewBase();
        }

        if(other.tag =="Player")
        {
            //Initiate GameOver sequence
        }
    }



}
