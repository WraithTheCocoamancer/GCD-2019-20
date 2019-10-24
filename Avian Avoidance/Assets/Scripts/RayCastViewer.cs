using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastViewer : MonoBehaviour
{
    private Camera cam;
    public float weaponRange = 10f;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = new Vector2();
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;
        Vector3 lineOrigin = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
        Debug.DrawRay(lineOrigin, cam.transform.forward * weaponRange, Color.red);
    }
}
