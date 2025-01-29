using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step : MonoBehaviour
{
    Animator anim;
    float v;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        v = Input.GetAxis("Vertical");
        if(v>0){
            anim.SetBool("step", true);
            if(Input.GetKeyDown("left shift")){
                anim.SetBool("run", true);
            }
            if(Input.GetKeyUp("left shift")){
                anim.SetBool("run", false);
            }
            }else{
                anim.SetBool("step", false);
            }
        }
}
