using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistracted : MonoBehaviour
{
    private Distraction DistractionHit;
    public Vector3 EnemyDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        DistractionHit = GameObject.Find("Bird").GetComponent<Distraction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EnemyTurn();
        }
    }

    void EnemyTurn()
    {
        if (DistractionHit.DistractedEnemy())
        {
            EnemyDirection = DistractionHit.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(EnemyDirection, Vector3.up);
        }
        else
        {

        }
    }
}
