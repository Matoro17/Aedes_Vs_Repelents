using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    public int life;
    public int price;
    public int cooldown;
    public int cooldownLife;
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldownLife;
        life = 10;
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
            cd = cooldownLife;
            life--;
        }
        if (life == 0)
        {
            Destroy(this);
        }
    }
}
