using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour {

    bool jump;

    Character playerCharacter;

    void Start() {
        playerCharacter = GetComponent<Character>();
    }

    void FixedUpdate() {
        float forward = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");


        playerCharacter.Move(forward, turn, jump);
    }

}
