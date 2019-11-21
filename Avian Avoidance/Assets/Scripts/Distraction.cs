using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distraction : MonoBehaviour
{
    public float sphereRadius;
    Color colorStart = Color.red;
    Color colorEnd = Color.green;
    float duration = 1.0f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DistractedEnemy();
        }
        Debug.Log("Did not fire");
        
    }

    public bool DistractedEnemy()
    {
       
            Debug.Log("Pressed E");
            if (Physics.CheckSphere(transform.position, 5, 1 << 10))
            {

                Debug.Log("In range");
                float lerp = Mathf.PingPong(Time.time, duration) / duration;
                rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
                return true;
            }
            Debug.Log("Not in range");
            return false;
        
        
    }
}
