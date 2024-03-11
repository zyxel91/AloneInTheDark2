using UnityEngine;

public class Switch3_2 : MonoBehaviour
{
    public static int _Switch3_2;
    public Animator _anim;
    public GameObject pressE;
     private float myTime;
    private bool Timer = false;
    void Start()
    {
        _Switch3_2 = 0;
    }

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
                _Switch3_2 = 1;
                Timer = true;
        }
    }
     public void Update(){
                if (Timer == true) {
                myTime = myTime + Time.deltaTime;
                   
                    if (myTime > 15) {
                        Timer = false;
                        myTime = 0;
                        _Switch3_2 = 0;
                        _anim.Play("switchOFFAnim");
                    }
                }
            }
}
