using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    private Animator anim;
    private bool firstBG;

    private void Awake() {
        anim = GetComponent<Animator>();
        firstBG = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            firstBG = !firstBG;
            anim.SetBool("firstBG", firstBG);
        }
    }
}
