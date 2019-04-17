using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mosquitoBase : MonoBehaviour
{

    public int rateOfAttack;

    public float mosquitoLife, vel;
    public bool canWalk, Canhit;
    int layer;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Canhit = true;
        rb = GetComponent<Rigidbody>();

    }

    void DetectTower()
    {
        Ray ray = new Ray(transform.position, Vector3.back);
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back)*10, Color.yellow);
        if (Physics.Raycast(ray, out hit, 100, layer))
        {
            canWalk = false;
            if (Canhit) {
                StartCoroutine(DelayEat(hit.collider));
            }
        }
        else{
            canWalk = Canhit = true;
            StopCoroutine("DelayEat");
        }
    }

    IEnumerator DelayEat(Collider col)
    {
        Canhit = false;
        yield return new WaitForSeconds(2);
        Canhit = true;
        if (col != null)
        {
            col.transform.gameObject.GetComponent<TowerBase>().life--;
        }
    }

    private void FixedUpdate()
    {
        if (canWalk){
            rb.velocity = new Vector3(-vel * Time.deltaTime, 0);
            transform.position += Time.deltaTime * transform.forward * 80;
        }
        else{
            rb.velocity = Vector3.zero;
        }
    }

    void CheckDeath()
    {
        if(mosquitoLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        DetectTower();
        CheckDeath();
    }
}
