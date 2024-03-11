using UnityEngine;

public class LeftPlatSwitch : MonoBehaviour
{
     public static int leftPlatSwitch;
     public GameObject pressE;
    public Animator _anim;
    private float myTime;
    private bool Timer = false;
    void Start()
    {
        leftPlatSwitch = 0;
    }
private void OnCollisionExit2D(Collision2D collision) {
    if (collision.collider) {
            pressE.SetActive(false);}
}
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.collider) {
            pressE.SetActive(true);} else {
                pressE.SetActive(false);
                }
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E)) {
                _anim.Play("switchONAnim");
                leftPlatSwitch = 1;
                Timer = true;
        }
    }
            public void Update(){
                if (Timer == true) {
                myTime = myTime + Time.deltaTime;
                    Debug.Log(myTime);
                    if (myTime > 2) {
                        Timer = false;
                        myTime = 0;
                        leftPlatSwitch = 0;
                        _anim.Play("switchOFFAnim");
                    }
                }
            }

}
