using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{

    private EnemyMove movscr;
    public float damage;
    public float Cooldown;
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        movscr = gameObject.GetComponent<EnemyMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cd > 0)
        {
            cd -= Time.deltaTime;
        }
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, Vector3.back, out hit,50))
        {
            Debug.DrawRay(transform.position, Vector3.back *50, Color.green);
            if (hit.transform.tag == "projectile")
            {
                movscr.canmove = true;
            }
            else if (hit.transform.tag == "Tower")
            {
                movscr.canmove = false;
                if (cd <= 0)
                {
                    Health hscr = hit.transform.gameObject.GetComponent<Health>();
                    hscr.health -= damage;
                    cd = Cooldown;
                }
            }else if (hit.transform.tag == "house")
            {
                GameObject.Find("GameLogic").GetComponent<LoseGame>().lost = true;
            }
            else if (hit.transform.tag == "Enemy")
            {
                movscr.canmove = true;
            }
            
        }else if (movscr.canmove == false)
        {
            movscr.canmove = true;
        }
    }
}
