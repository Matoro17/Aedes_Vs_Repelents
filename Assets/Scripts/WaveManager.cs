using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class WaveManager : MonoBehaviour
{
    public int NumOut;
    public GameObject[] Enemies;
    public float Cooldown;
    public Text points;
    private float cd;
    public int pontos;

    private LoseGame losegame;
    

    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown * 2;
        pontos = 0;
        losegame = gameObject.GetComponent<LoseGame>();
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
        points.text = "Points: " + pontos;
        if (cd >0)
        {
            cd -= Time.deltaTime;
        }
        else
        {
            cd = Cooldown;
            Vector3 pos = new Vector3(randomPos(Random.Range(0, 6)), 39,1345);
            int index = Random.Range(0, 3);
            if(index == 0)
            {
                index = 1;
            }
            else
            {
                index = 0;
            }
            if (!losegame.lost)
            {
                Instantiate(Enemies[index], pos, Quaternion.Euler(0, -90, 0));
            }
            
            NumOut++;
        }
    }

    public void resetcd()
    {
        cd = Cooldown;
    }

    public void addPoints(int plus)
    {
        pontos = pontos + plus;
    }
}
