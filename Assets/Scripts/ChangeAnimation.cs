using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    private Animator anim;
    private string[] triggers = {"Forward", "Front_Angle", "Side_Angle", "Back_Angle", "Rear_Angle",
                                 "Back_Angle", "Side_Angle", "Front_Angle"};
    private int i;

    private void Awake() {
        anim = GetComponent<Animator>();
        i = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(i == 4 || i == triggers.Length - 1)
                flip();

            i = i < triggers.Length - 1 ? i + 1 : 0;
            anim.SetTrigger(triggers[i]);
        }
    }

    private void flip() {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
