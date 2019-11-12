using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayCastFromCamera : MonoBehaviour
{
    ////https://www.youtube.com/watch?v=oEywwHERy1U code from this video going to alter it to give hit info for world location
    /// Fires a Raycast from the screen mousepoint into the world extrapolating out.
    /// have altered it to give me the world point and adding the normal too it
    /// 
    /// </summary>
    public float Length;
    public LayerMask layermask;


 
    public Vector3 VectorHit = Vector3.zero;


    // Update is called once per frame
    private void Update()
    {

    }

    public Vector3 CheckRaycast()
    {

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Length, layermask))
            {
                Debug.Log(hit.collider.name);
                Debug.Log(hit.point);
                Debug.Log(hit.normal);

                Debug.Log("Vector Hit");
                return VectorHit = hit.point + hit.normal * 0.3f;
                

            }

            else
            {
                Debug.Log("Vector Miss");
                return VectorHit = Vector3.zero;
            }
        }
        else
        {
            return Vector3.zero;
        }
    }
}
