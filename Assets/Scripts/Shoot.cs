using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Cooldown;
    private float cd;
    public GameObject projectile;
    public bool hasenemy;   

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
            if (Physics.Raycast(transform.position, Vector3.forward,out hit, 1000))
            {
                if (hit.transform.tag == "Enemy" || hasenemy)
                {
                    if (cd <=0)
                    {
                        cd = Cooldown;
                        Instantiate(projectile, transform.position, Quaternion.identity);
                    }
                    hasenemy = true;
                }else if (hit.transform.tag == "Tower")
                {
                    Shoot scr = hit.transform.gameObject.GetComponent<Shoot>();
                    if (scr.hasenemy)
                    {
                        hasenemy = true;
                    }
                    else
                    {
                        hasenemy = false;
                    }
                }
                else
                {
                    hasenemy = false;
                }
            }
            else
            {
                hasenemy = false;
            }
            
        }
    }
}
