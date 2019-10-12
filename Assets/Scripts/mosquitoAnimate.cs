using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mosquitoAnimate : MonoBehaviour
{
    Animator anim;
    EnemyMove enemimove;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        enemimove = gameObject.GetComponent<EnemyMove>();
    }

    // Update is called once per frame
    void Update()
    {
       
            anim.Play("walk");
            
        
    }

    bool AnimatorisPlaying()
    {
        return anim.GetCurrentAnimatorStateInfo(0).normalizedTime <1;
    }
}
