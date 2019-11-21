using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Special thanks to third year students who helped me passing peramiters and having the bird turn I'm sorry I didn't get your names but i still wanna get you a pepsi
public class BirdMoveScript : MonoBehaviour
{

    public Vector3 RaycastHit = Vector3.zero;
    public Vector3 BirdLocation = Vector3.zero;
    public Vector3 BirdDirection = Vector3.zero;


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
            BirdDirection = RaycastHit - BirdLocation;
            transform.rotation = Quaternion.LookRotation(BirdDirection, Vector3.up);
            transform.position = Vector3.MoveTowards(transform.position, RaycastHit, 100f); //to be replaced later with smooth movement.
        }
    } 
  
}
