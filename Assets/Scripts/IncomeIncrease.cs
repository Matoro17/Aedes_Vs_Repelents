using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeIncrease : MonoBehaviour
{
    public float Cooldown;
    private float cd;
    public float income;
    private Money mscr;

    // Start is called before the first frame update
    void Start()
    {
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else
        {
            cd = Cooldown;
            mscr.money += income;
        }
    }
}
