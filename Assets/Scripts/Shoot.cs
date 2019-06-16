using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Cooldown;
    private float cd;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (cd >0)
        {
            cd -= Time.deltaTime;
        }
        else
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.forward,out hit, 500))
            {
                if (hit.transform.tag == "Enemy")
                {
                    cd = Cooldown;
                    Instantiate(projectile, transform.position, Quaternion.identity);
                }
            }
            
        }
    }
}
