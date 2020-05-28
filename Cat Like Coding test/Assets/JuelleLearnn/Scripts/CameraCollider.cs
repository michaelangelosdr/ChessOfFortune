using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{

    [SerializeField]
    float cameraMoveSpeedY;

    [SerializeField]
    GameObject CameraObject;

    private void Update()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    public void moveCamera()
    {
        CameraObject.transform.position += new Vector3(0, cameraMoveSpeedY, 0);
    }
}
