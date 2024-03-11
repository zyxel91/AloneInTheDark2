using UnityEngine;

public class switch2_6 : MonoBehaviour
{
    public static int _Switch2_6;
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
            MainSwitch2_0.MainSwitch = 0;
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                _Switch2_6 = 1;
        }
    }
}
