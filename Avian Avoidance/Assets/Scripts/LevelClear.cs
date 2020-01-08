using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelClear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameSceneManager;
    public GameObject Player;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            GameSceneManager.GetComponent<GameManager>().WinGame();
        }
    }
}
