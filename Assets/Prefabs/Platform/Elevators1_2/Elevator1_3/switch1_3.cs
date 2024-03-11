using UnityEngine;

public class switch1_3 : MonoBehaviour
{
    public static int _Switch1_3;
    public Animator _anim;
    public GameObject pressE;
    void Start()
    {
        _Switch1_3 = 0;
    }

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
                _anim.Play("switchONAnim");
                _Switch1_3 = 1;
        }
    }
}
