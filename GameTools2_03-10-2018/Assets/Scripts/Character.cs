using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    Animator anim; 

	void Start () {
        anim = GetComponent<Animator>();
	}

    public void Move(float forward, float turn, bool jump) {
        anim.SetFloat("Turn", turn);
        anim.SetFloat("Forward", forward);

        if (jump) {
            anim.SetTrigger("Jump");
        }
    }

}
