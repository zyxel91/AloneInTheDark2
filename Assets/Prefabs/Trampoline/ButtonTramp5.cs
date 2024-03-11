
using UnityEngine;

public class ButtonTramp5 : MonoBehaviour
{
    public GameObject pressE;
    public Animator anim;
    public static int Button_5;

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
                Button_5= 1;
        }
    }

}

