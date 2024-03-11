using UnityEngine;

public class DawnSwitchPos : MonoBehaviour
{
    public static int DawnSwitch;
    public Animator _anim;
    public GameObject pressE;
    void Start()
    {
        DawnSwitch = 0;
       
    }

    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.gameObject.tag == "Player") {
            pressE.SetActive(false);}
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            pressE.SetActive(true);
            } 
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                DawnSwitch = 1;
        }
    }
}
