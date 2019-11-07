using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoveScript : MonoBehaviour
{

    public Vector3 BirdDirection;
    private RayCastFromCamera raycastfromcamera;
    // Start is called before the first frame update
    void Start()
    {
       raycastfromcamera = GetComponent<RayCastFromCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {

            BirdDirection = raycastfromcamera.VectorHit;
            Debug.Log(BirdDirection);
            
        }
    }
}
