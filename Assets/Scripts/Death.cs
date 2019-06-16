using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isTower;
    private Health hscr;
    private Money mscr;
    private EnemyStatus escr;

    private void Start()
    {
        hscr = gameObject.GetComponent<Health>();
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
        if (!isTower)
        {
            escr = gameObject.GetComponent<EnemyStatus>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hscr.health <= 0) {
            if (isTower)
            {
                Destroy(gameObject);
            }
            else
            {
                mscr.money += escr.Worth;
                Destroy(gameObject);
            }
        }
    }
}
