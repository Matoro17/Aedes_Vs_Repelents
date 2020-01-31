using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTimer : MonoBehaviour
{
    public int cooldownLife;
    public float cd;
    private float life;
    private float fullhealth;

    // Start is called before the first frame update
    void Start()
    {
        cd = cooldownLife;
        life = gameObject.GetComponent<Health>().health;
        fullhealth = life;
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
            gameObject.GetComponent<Health>().health -= 50;
        }
        
}
}
