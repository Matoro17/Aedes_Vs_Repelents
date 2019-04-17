using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] mosquitos;
    public Transform[] points;
    public float rate = 60 / 130;
    private float timer;
    
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (timer > rate){ 

            GameObject cube = Instantiate(mosquitos[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            cube.transform.localPosition = Vector3.zero;

            timer -= rate;

        }

        timer += Time.deltaTime;

    }
}
