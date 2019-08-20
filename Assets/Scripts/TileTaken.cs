using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTaken : MonoBehaviour
{

    public bool isTaken;
    public GameObject Tower;

    private void Update()
    {
        if(Tower == null)
        {
            isTaken = false;
        }
    }

}
