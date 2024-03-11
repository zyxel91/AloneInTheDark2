using UnityEngine;

public class LeftSwitchPos : MonoBehaviour
{
    public static int leftSwitch;
    public Animator _anim;
    public GameObject pressE;
    void Start()
    {
        leftSwitch = 0;
       
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
                leftSwitch = 1;
        }
    }
}
