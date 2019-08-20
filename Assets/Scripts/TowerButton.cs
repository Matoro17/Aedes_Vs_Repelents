using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerButton : MonoBehaviour
{
    public int Index;
    public setTower setscr;

    void OnClick()
    {
        setscr.Selected = Index;
    }

    // Start is called before the first frame update
    void Start()
    {
        setscr = GameObject.Find("Main Camera").AddComponent<setTower>();
    }
    
}
