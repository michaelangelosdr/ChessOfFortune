using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baselevelcreator : MonoBehaviour
{

    [SerializeField]
    GameObject m_Base;

    [SerializeField]
    int NumberOfBases;

    [SerializeField]
    int minimumHeight;

    [SerializeField]
    float heightOffset;

    [SerializeField]
    float currentHighestHeight;

    [SerializeField]
    ScoreManager m_scoremanager;


    // Start is called before the first frame update
    void Start()
    {
        CreateBases();

       // InvokeRepeating("CreateNewBase", 3, 1);
    }


    private void CreateBases()
    {      
        for(int index =0;index<NumberOfBases;index++) 
        {
            GameObject new_base = Instantiate(m_Base , new Vector3(Random.Range(-2.25f,2.25f),minimumHeight+(heightOffset*index),1)  , Quaternion.identity);
        }


        currentHighestHeight = minimumHeight + (heightOffset * (NumberOfBases - 1));
    }

    public void CreateNewBase()
    {                                                                                                                         
        GameObject new_base = Instantiate(m_Base, new Vector3(Random.Range(-2.25f, 2.25f), currentHighestHeight + heightOffset, 1), Quaternion.identity);
        NumberOfBases++;
        currentHighestHeight = minimumHeight + (heightOffset * (NumberOfBases - 1));


        m_scoremanager.AddScore();
    }
}
