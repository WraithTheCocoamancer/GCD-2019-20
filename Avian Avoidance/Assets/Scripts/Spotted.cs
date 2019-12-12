using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotted : MonoBehaviour
{

    private EnemyVision Visioncheck;
    private GameObject ExclamationMark;
    // Start is called before the first frame update
    void Start()
    {
        Visioncheck = GameObject.Find("BadGuy").GetComponent<EnemyVision>();
        ExclamationMark = GameObject.Find("Exclamation");
        ExclamationMark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Visioncheck.playerspotted == true)
        {
            ExclamationMark.SetActive(true);
        }
        else
        {
                ExclamationMark.SetActive(false); 
        }
       
    }
}
