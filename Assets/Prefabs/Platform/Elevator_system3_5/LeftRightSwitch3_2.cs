using UnityEngine;

public class LeftRightSwitch3_2 : MonoBehaviour
{
   public GameObject PressE;
   public GameObject PressF;

   public Animator switchAnim;
   public Animator Platform;
   public int Switch3_5 = 0;
   public bool TimerRight = false;
   public bool TimerLeft = false;
   public float timer;
   public float timer2;
private void Update() {
    if (TimerRight == true) {
        timer = timer + Time.deltaTime;
        PressE.SetActive(false);
        if (timer > 20) {
            TimerRight = false;
            timer = 0f;
            Switch3_5 = 1;
        }
}

 Debug.Log(timer);
  
}
private void LateUpdate() {
    if (TimerLeft == true) {
        timer2 = timer2 + Time.deltaTime;
        PressF.SetActive(false);
        if (timer2 > 20) {
            TimerLeft = false;
            timer2 = 0f;
            Switch3_5 = 0;
        }
    }
    Debug.Log(timer2);
}
   private void OnCollisionStay2D(Collision2D collision) {
    if (collision.gameObject.tag == "Player" && Switch3_5 == 0 && TimerRight == false) {
        PressE.SetActive(true); 
        }
    if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
            
            TimerRight = true;
            switchAnim.Play("switchONAnim");
            Platform.Play("3_2SlidePlatformRight");
        }

        if (collision.gameObject.tag == "Player" && Switch3_5 == 1 && TimerLeft == false) {
        PressF.SetActive(true);
        }
    if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.F)) {
            
            TimerLeft = true;
            switchAnim.Play("switchOFFAnim");
            Platform.Play("3_2SlidePlatformLeft");
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            PressE.SetActive(false);
            PressF.SetActive(false);
        }
    }
   }


