using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTramp2 : MonoBehaviour
{
    public GameObject pressE;
    public Animator anim;
    public static int Button_2;

    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.collider) {
            pressE.SetActive(false);
            }

    
}
private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider) {
            pressE.SetActive(true);
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                anim.Play("TrampolineButton");
                Button_2 = 1;
        }
    }

}

