using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    private WaveManager wavescrip;
    private LoseGame losegame;
    private Money money;

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
        if (wavescrip.pontos >= 50)
        {
            winGame();
        }
    }

    public void winGame()
    {
        int pontos = wavescrip.pontos;
        float energia = money.money;
        final.color = new Color(255,255,255,255);
        final.text = "Congratulations, your Score is: \n Enemies Killed: "+pontos+"\n Energy acquired: "+energia;

        losegame.lost = true;

    }
}
