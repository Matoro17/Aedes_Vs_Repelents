using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    public int life;
    public int price;
    public int cooldown;

    // Start is called before the first frame update
    void Start()
    {
        life = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            Destroy(this);
        }
    }
}
