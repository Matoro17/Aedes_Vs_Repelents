using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTower : MonoBehaviour
{
    public int Selected;
    public GameObject[] towers;
    public float[] prices;
    public GameObject Tile;
    private Money mscr;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        mscr = GameObject.Find("GameLogic").GetComponent<Money>();
    }

    public void ChangeIndex(int v)
    {
        this.Selected = v;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit,1000))
        {
            if(hit.transform.tag == "Tile")
            {
                Tile = hit.transform.gameObject;

            }
            else
            {
                Tile = null;
            }
        }
        if (Input.GetMouseButtonDown(0) && Tile != null)
        {
            TileTaken tscr = Tile.GetComponent<TileTaken>();
            if (!tscr.isTaken && mscr.money >= (int)prices[Selected])
            {
                mscr.money -= (int)prices[Selected];
                Vector3 pos = new Vector3(Tile.transform.position.x,50,Tile.transform.position.z);
                tscr.Tower = (GameObject)Instantiate(towers[Selected], pos, Quaternion.identity);
                GameObject go = Instantiate(effect) as GameObject;
                go.transform.position = pos;
                tscr.isTaken = true;
                Selected = 50;
            }
        }
    }
}
