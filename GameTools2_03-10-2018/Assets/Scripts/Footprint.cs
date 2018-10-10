using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footprint : MonoBehaviour {

    public GameObject footprintPrefab;

    Animator anim;

    Transform rightFoot;
    Transform leftFoot;

    bool stepped = false;

    void Start() {
        anim = GetComponent<Animator>();

        rightFoot = anim.GetBoneTransform(HumanBodyBones.RightFoot);
        leftFoot = anim.GetBoneTransform(HumanBodyBones.LeftFoot);
    }

    public void PrintFootprint() {
        Debug.Log("Footprint");

        if (!stepped) {
            Instantiate(footprintPrefab, leftFoot.position, footprintPrefab.transform.rotation);
            stepped = !stepped;
        } else {
            Instantiate(footprintPrefab, rightFoot.position, footprintPrefab.transform.rotation);
            stepped = !stepped;
        }
    }

}
