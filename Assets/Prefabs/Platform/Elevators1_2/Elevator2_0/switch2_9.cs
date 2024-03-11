using UnityEngine;

public class switch2_9 : MonoBehaviour
{
    public static int _Switch2_9;
    public Animator _anim;
    public GameObject pressE;
    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.gameObject.tag == "Player") {
            pressE.SetActive(false);
            }
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            pressE.SetActive(true);
            switch2_8._Switch2_8 = 0;
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                _Switch2_9 = 1;
        }
    }
}
