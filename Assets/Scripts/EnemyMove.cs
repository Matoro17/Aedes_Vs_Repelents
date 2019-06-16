using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MovimentSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * MovimentSpeed * Time.deltaTime);
    }
}
