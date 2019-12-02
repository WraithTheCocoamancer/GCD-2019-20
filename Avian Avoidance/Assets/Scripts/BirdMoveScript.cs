using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Special thanks to third year students:jack Griffiths, Aden webb & others who's name I have yet to get
public class BirdMoveScript : MonoBehaviour
{

    public Vector3 RaycastHit = Vector3.zero;
    public Vector3 BirdLocation = Vector3.zero;
    public Vector3 BirdDirection = Vector3.zero;
    public BoxCollider Bird;
    public Vector3 BirdTakeoff = Vector3.up;
    private RayCastFromCamera raycastfromcamera;

    // Start is called before the first frame update

    void Start()
    {
        Bird = GetComponent<BoxCollider>();
        raycastfromcamera = GameObject.Find("Camera").GetComponent<RayCastFromCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + BirdTakeoff, 0.01f);
            RaycastHit = raycastfromcamera.CheckRaycast();
            //Debug.Log(RaycastHit);
            BirdLocation = transform.position;
            Debug.Log(BirdLocation);
            BirdDirection = RaycastHit - BirdLocation;
            transform.rotation = Quaternion.LookRotation(BirdDirection, Vector3.up);
            Bird.attachedRigidbody.useGravity = false;
        }

        if (Vector3.Distance(transform.position, RaycastHit) >= 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, RaycastHit, 0.01f); //to be replaced later with smooth movement.
            
        }
        if (Vector3.Distance(transform.position, RaycastHit) <= 0.5f)
        {
            Bird.attachedRigidbody.useGravity = true;

        }
    } 
  
}
