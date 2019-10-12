using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class LoseGame : MonoBehaviour
{

    public bool lost;
    private Money mscr;
    private float initmoney;
    private WaveManager wavscr;

    private int pontuacao;
    private float energia;
    public Text final;

    private bool alreadydonethat;

    // Start is called before the first frame update
    void Start()
    {
        mscr = gameObject.GetComponent<Money>();
        wavscr = gameObject.GetComponent<WaveManager>();
        initmoney = mscr.money;
        lost = false;
        alreadydonethat = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lost)
        {
            wavscr.NumOut = 0;
            wavscr.resetcd();
            GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
            GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            GameObject[] projs = GameObject.FindGameObjectsWithTag("projectile");

            for (int i = 0; i < towers.Length; i++)
            {
                Destroy(towers[i]);
            }
            for (int y = 0; y < enemies.Length; y++)
            {
                Destroy(enemies[y]);
            }
            for (int z = 0; z < tiles.Length; z++)
            {
                TileTaken tscr = tiles[z].GetComponent<TileTaken>();
                tscr.isTaken = false;
            }
            for (int a = 0; a < projs.Length; a++)
            {
                Destroy(projs[a]);
            }

            if (!alreadydonethat) { 
                pontuacao = wavscr.pontos;
                energia = mscr.money;
                alreadydonethat = true;
            }
            final.color = new Color(255, 255, 255, 255);
            final.text = "You Lose\n The mosquitoes entered your house\n Final Score: \n Enemies killed: "+ pontuacao + "\nEnergy: "+energia;
        }
    }
}
