using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MovimentSpeed;
    public bool canmove;

    private void Start()
    {
        canmove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            transform.Translate(Vector3.left * MovimentSpeed * Time.deltaTime);
                     
        }
    }
}
