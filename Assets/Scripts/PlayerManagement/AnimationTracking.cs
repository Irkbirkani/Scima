using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTracking : MonoBehaviour {

    public string animTo1;
    public string animTo2;
    private Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
        
    }

   public void animate(string anim)
    {
        if (anim == animTo1)
            ani.SetBool("anim1", true);
        else if (anim == animTo2)
            ani.SetBool("anim2", true);
    }
}
