using UnityEngine;

public class MainSwitch2_0 : MonoBehaviour
{
    public static int MainSwitch;
    public Animator _anim;
    public GameObject pressE;
    public GameObject SwitchText;
    
    private void OnCollisionExit2D(Collision2D collision) {
    if (collision.gameObject.tag == "Player") {
            SwitchText.SetActive(false);
            pressE.SetActive(false);
            }
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider && (switch2_1._Switch2_1 == 0 || switch2_2._Switch2_2 == 0 || switch2_3._Switch2_3 == 0 || switch2_4._Switch2_4 == 0 || switch2_5._Switch2_5 == 0)) {
            SwitchText.SetActive(true);
            } 
             if (collision.gameObject.tag == "Player" && switch2_1._Switch2_1 == 1 && switch2_2._Switch2_2 == 1 && switch2_3._Switch2_3 == 1 && switch2_4._Switch2_4 == 1 && switch2_5._Switch2_5 == 1) {
                pressE.SetActive(true);
        }
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E) && switch2_1._Switch2_1 == 1 && switch2_2._Switch2_2 == 1 && switch2_3._Switch2_3 == 1 && switch2_4._Switch2_4 == 1 && switch2_5._Switch2_5 == 1) {
                _anim.Play("switchONAnim");
                MainSwitch = 1;
        }
    }
}
