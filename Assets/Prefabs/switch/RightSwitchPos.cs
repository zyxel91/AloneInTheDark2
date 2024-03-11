using UnityEngine;

public class RightSwitchPos : MonoBehaviour
{
    public static int RightSwitch;
    public Animator _anim;
    public GameObject pressE;
    void Start()
    {
        RightSwitch = 0;
       
    }

    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.collider) {
            pressE.SetActive(false);}
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider) {
            pressE.SetActive(true);
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                RightSwitch = 1;
        }
    }
}
