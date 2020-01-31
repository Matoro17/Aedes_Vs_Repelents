using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    private WaveManager wavescrip;
    private LoseGame losegame;
    private Money money;
    public int limit;

    public Text final;

    // Start is called before the first frame update
    void Start()
    {
        wavescrip = gameObject.GetComponent<WaveManager>();
        losegame = gameObject.GetComponent<LoseGame>();
        money = gameObject.GetComponent<Money>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wavescrip.pontos >= limit)
        {
            if (limit == 20)
            {
                winGame1();
            }else if (limit == 30)
            {
                wingame2();
            }else if (limit==40)
            {
                wingame3();
            }
        }
    }

    public void winGame1()
    {
        SceneManager.LoadScene("Fim1");
        PlayerPrefs.SetInt("stage", 1);
        //int pontos = wavescrip.pontos;
        //float energia = money.money;
        //final.color = new Color(255,255,255,255);
        //final.text = "Congratulations, your Score is: \n Enemies Killed: "+pontos+"\n Energy acquired: "+energia;

        losegame.lost = true;

    }
    public void wingame2()
    {
        SceneManager.LoadScene("Fim2");
        PlayerPrefs.SetInt("stage", 2);
    }
    public void wingame3()
    {
        SceneManager.LoadScene("Fim3");
    }
}
