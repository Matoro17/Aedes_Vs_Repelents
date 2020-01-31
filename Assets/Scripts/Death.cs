using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isTower;
    private Health hscr;
    private Money mscr;
    private EnemyStatus escr;
    private WaveManager wavescrip;

    public GameObject deatheffect;

    private void Start()
    {
        wavescrip = GameObject.Find("GameLogic").GetComponent<WaveManager>();
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
                GameObject go = Instantiate(deatheffect) as GameObject;
                go.transform.position = transform.position;
            }
            else
            {
                
                //mscr.money += escr.Worth;
                Destroy(gameObject);
                GameObject go = Instantiate(deatheffect) as GameObject;
                go.transform.position = transform.position;
                wavescrip.addPoints(escr.Worth);
            }
        }
    }
}
