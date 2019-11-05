using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayCastFromCamera : MonoBehaviour
{
    ////https://www.youtube.com/watch?v=oEywwHERy1U code from this video going to alter it to give hit info for world location
    public float Length;
    public LayerMask layermask;
    public GameObject prefab;
    public static Vector3 BirdDestination;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit, Length, layermask))
            {
                Debug.Log(hit.collider.name);
                Debug.Log(hit.point);
                Debug.Log(hit.normal);
                Instantiate(prefab, hit.point + hit.normal * 0.3f, Quaternion.identity);
                BirdDestination = hit.point + hit.normal * 0.3f;
            }
        }
    }
}
