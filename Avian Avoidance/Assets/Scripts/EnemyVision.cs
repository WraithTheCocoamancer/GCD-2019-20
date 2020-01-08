using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    
    public Rigidbody Player;
    private Vector3 PlayerLocation = Vector3.zero;
    private Vector3 PlayerDirection = Vector3.zero;
    private float PlayerDistance = 0;
    public bool playerspotted = false;
    [SerializeField]
    [Range(0, 1)]
    private float VisionSize = 0.9f;
    [SerializeField] private float SpottedTime = 3f;
    private float spottedDelay;
    public GameObject GameSceneManager;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Rigidbody>();
        
        
    }

    public void Vision()
    {
        
        PlayerLocation = Player.transform.position;
        PlayerDirection = PlayerLocation - transform.position;
        var FirstVector = transform.forward;
        var SecondVector = PlayerDirection.normalized;
        PlayerDistance = Vector3.Distance(Player.transform.position, transform.position);
        RaycastHit hit;
        Ray checkray = new Ray(transform.position, PlayerDirection);
        Physics.Raycast(checkray, out hit, 10f);
        
        if (PlayerDistance < 10 && hit.collider.gameObject.name == "Player")
        {


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
                playerspotted = true;
                spottedDelay += Time.deltaTime;
                    if (spottedDelay > SpottedTime)
                {
                    GameSceneManager.GetComponent<GameManager>().EndGame();
                }
            }
            else
            {
                playerspotted = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        Vision();
    }
}
