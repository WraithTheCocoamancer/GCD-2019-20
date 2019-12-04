using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    private Transform LineOfSight;
    public Rigidbody Player;
    public Vector3 PlayerLocation = Vector3.zero;
    [SerializeField] private float VisionSize = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("ThirdPersonController").GetComponent<Rigidbody>();
        
    }

    public void Vision()
    {
        LineOfSight = null;
        PlayerLocation = Player.transform.position;
        var FirstVector = Vector3.forward;
        var SecondVector = PlayerLocation;

        var LookPercentage = Vector3.Dot(FirstVector.normalized, SecondVector.normalized);
        Debug.Log(LookPercentage);
        //PlayerLocation.LookPercentage = LookPercentage;

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
