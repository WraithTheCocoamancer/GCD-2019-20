using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastSight : MonoBehaviour
{
    private Camera cam;
    public GameObject prefab;
    //public float fireRate = .5f;
    //public Transform screenpoint;
    public float weaponRange = 10f;
    //private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    //private LineRenderer laserLine;
    //private float nextFire;
    //Vector2 mousePos = new Vector2();
    //Event currentEvent = Event.current;
    //Vector3 point = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        //laserLine = GetComponent<LineRenderer>();
    }

    // Update is called once per frame

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = new Vector2();

            // Get the mouse position from Event.
            // Note that the y position from Event is inverted.
            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;
            RaycastHit hit;

            Vector3 clickPoint = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
            Vector3 ScreenPoint = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
            if (Physics.Raycast(ScreenPoint, cam.transform.forward, out hit, weaponRange))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
            }
            else
            {
                Instantiate(prefab, clickPoint, Quaternion.identity);
            }
        }

        //if (Input.GetButton("Fire1") && Time.time > nextFire)
        //{
        //    nextFire = Time.time + fireRate;

        //    StartCoroutine(ShotEffect());

        //    point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        //    Vector3 RayOrigin = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        //    RaycastHit hit;

        //    laserLine.SetPosition(0, point);
        //if (Physics.Raycast(RayOrigin, cam.transform.forward, out hit, weaponRange))
        //    {
        //        laserLine.SetPosition(1, hit.point);
        //    }
        //    else
        //    {
        //        laserLine.SetPosition(1, RayOrigin + (cam.transform.forward * weaponRange));
        //    }
        //}
    }

    //private IEnumerator ShotEffect()
    //{
    //    //laserLine.enabled = true;
    //    //yield return shotDuration;
    //    //laserLine.enabled = false;
    //}
}
