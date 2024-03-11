using UnityEngine;

public class switch2_5 : MonoBehaviour
{
    public static int _Switch2_5;
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
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                _Switch2_5 = 1;
        }
    }
}
