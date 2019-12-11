using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistracted : MonoBehaviour
{
    private Distraction DistractionHit;
    public Vector3 EnemyDirection = Vector3.zero;
    private Quaternion firstRotation;
    private Quaternion SecondRotation;
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

            firstRotation = transform.rotation;
            EnemyDirection = DistractionHit.transform.position - transform.position;
            SecondRotation = Quaternion.LookRotation(EnemyDirection);
            transform.rotation = Quaternion.Lerp(firstRotation, SecondRotation, 1f);
        }
        else
        {

        }
    }
}
