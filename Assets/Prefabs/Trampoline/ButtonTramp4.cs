using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTramp4 : MonoBehaviour
{
    public GameObject pressE;
    public Animator anim;
    public static int Button_4;
    private bool TimerStart = false;
    private float timer;
    public float timerNum;
    public GameObject Timertext;
    public Text text;
    private void Start() {
        
    }
    private void Update() {
        switch(TimerStart) {
        case true: 
        timer = timer + Time.deltaTime;
        Timertext.SetActive(true);
        text.text = "" + Math.Ceiling(timer);
        
        if (timer > timerNum){
            Button_4 = 0;
            anim.Play("TrampolineButtonOff");
            Timertext.SetActive(false);
            TimerStart = false;
        }
        break;
        case false:
            timer = 0f;
        break;
        }
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
                anim.Play("TrampolineButton");
                TimerStart = true;
                Button_4 = 1;
        }
    }

}

