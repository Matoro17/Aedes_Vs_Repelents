using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    private int stage;
    // Start is called before the first frame update
    void Start()
    {
        stage = PlayerPrefs.GetInt("stage",0);

        if (stage==0)
        {
            button2.SetActive(false);
            button3.SetActive(false);
        }else if (stage == 1)
        {
            button2.SetActive(true);
            button3.SetActive(false);
        }else if (stage==2)
        {
            button2.SetActive(true);
            button3.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
