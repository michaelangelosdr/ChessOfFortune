using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class DoodleJumper : MonoBehaviour
{
    private Rigidbody my_rigidbody;

    [SerializeField]
    private float JumpMultiplier;

    [SerializeField]
    private float movementSpeed;
  
    // Start is called before the first frame update
    void Start()
    {
        my_rigidbody = GetComponent<Rigidbody>();      
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if(Input.GetKey(KeyCode.A) && transform.position.x > -2.25f)
        {           
           MoveLeft();
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 2.25f)
        {
            MoveRight();
        }

    }

    private void Jump()
    {
        my_rigidbody.AddForce(Vector2.up * JumpMultiplier);
    }

    private void MoveLeft()
    {
        gameObject.transform.position -= new Vector3(movementSpeed, 0, 0);
    }
    
    private void MoveRight()
    {
        gameObject.transform.position += new Vector3(movementSpeed, 0, 0);
    }


    private void OnCollisionEnter(Collision collision)
    {
        my_rigidbody.velocity = Vector3.zero;
        Jump();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Camera")
        {
            other.GetComponent<CameraCollider>().moveCamera();
        }
    }



}
