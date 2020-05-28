using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardToken : MonoBehaviour
{
    protected string TokenID;

    public virtual void SetID(string name)
    {
        Debug.Log("Added ID");
    }
}
