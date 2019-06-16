using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float MovementSpeed;
    public float Damage;
    public Vector3 initpos;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        initpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position,initpos)> 800)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Health>().health -= Damage;
            //Criar particulas
            Destroy(gameObject);
        }
    }
}
