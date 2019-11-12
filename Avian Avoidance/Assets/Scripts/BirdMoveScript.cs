using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoveScript : MonoBehaviour
{

    public Vector3 RaycastHit = Vector3.zero;
    public Vector3 BirdLocation = Vector3.zero;
    public Vector3 BirdHeading = Vector3.zero;
    public Vector3 BirdDirection = Vector3.zero;
    public Vector3 BirdDistance = Vector3.zero;

    private RayCastFromCamera raycastfromcamera;

    // Start is called before the first frame update

    void Start()
    {
        raycastfromcamera = GameObject.Find("Camera").GetComponent<RayCastFromCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit = raycastfromcamera.CheckRaycast();
            //Debug.Log(RaycastHit);
            BirdLocation = transform.position;
            Debug.Log(BirdLocation);
            BirdHeading = RaycastHit - BirdLocation;
            

        }
    } 
  
}
