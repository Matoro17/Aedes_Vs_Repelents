using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public int NumOut;
    public GameObject[] Enemies;
    public float Cooldown;
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown * 2;
    }
       
    float randomPos(int n)
    {
        if(n == 0)
        {
            return 585;
        }else if(n == 1)
        {
            return 481;
        }
        else if (n == 2)
        {
            return 377;
        }
        else if (n == 3)
        {
            return 272;
        }
        else if (n == 4)
        {
            return 172;
        }
        else
        {
            return 65;
        }
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
            cd = Cooldown;
            Vector3 pos = new Vector3(randomPos(Random.Range(0, 5)), 39,1345);
            int index = Random.Range(0, Enemies.Length);
            Instantiate(Enemies[index],pos,Quaternion.Euler(0,-90,0));
            NumOut++;
        }
    }
}
