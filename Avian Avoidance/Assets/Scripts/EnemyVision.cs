using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    
    public Rigidbody Player;
    private Vector3 PlayerLocation = Vector3.zero;
    private Vector3 PlayerDirection = Vector3.zero;
    private float VisionSize = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("ThirdPersonController").GetComponent<Rigidbody>();
        
    }

    public void Vision()
    {
        
        PlayerLocation = Player.transform.position;
        PlayerDirection = PlayerLocation - transform.position;
        var FirstVector = Vector3.forward;
        var SecondVector = PlayerDirection.normalized;

        var LookPercentage = Vector3.Dot(FirstVector, SecondVector);
        //Debug.Log(LookPercentage);
        //PlayerLocation.LookPercentage = LookPercentage;
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(LookPercentage);
        }
        if (LookPercentage > VisionSize)
        {
            Debug.Log("Spotted!");
                
            }
    }

    // Update is called once per frame
    void Update()
    {
        Vision();
    }
}
