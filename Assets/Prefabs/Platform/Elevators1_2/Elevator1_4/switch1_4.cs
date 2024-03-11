using UnityEngine;

public class switch1_4 : MonoBehaviour
{
    public static int _Switch1_4;
    public Animator _anim;
    public GameObject pressE;
    public GameObject pressF;
    void Start()
    {
        _Switch1_4 = 0;
    }

    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.collider) {
            pressE.SetActive(false);
            pressF.SetActive(false);
            }
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider && _Switch1_4 == 0) {
            pressE.SetActive(true);
            } 
            if (collision.collider && _Switch1_4 == 1) {
                pressF.SetActive(true);
                }
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                _Switch1_4 = 1;
        }
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.F) && _Switch1_4 == 1) {
                _anim.Play("switchOFFAnim");
                _Switch1_4 = 0;
        }
    }
}
