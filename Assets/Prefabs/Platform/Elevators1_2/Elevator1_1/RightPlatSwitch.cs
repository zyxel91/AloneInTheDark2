using UnityEngine;

public class RightPlatSwitch : MonoBehaviour
{
   public static int rightPlatSwitch;
   public GameObject pressE;
    public Animator _anim;
    private float myTime;
    private bool Timer = false;
    void Start()
    {
        rightPlatSwitch = 0;
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
                rightPlatSwitch = 1;
                Timer = true;
        }
    }
            public void Update(){
                if (Timer == true) {
                myTime = myTime + Time.deltaTime;
                    if (myTime > 2) {
                        Timer = false;
                        myTime = 0;
                        rightPlatSwitch = 0;
                        _anim.Play("switchOFFAnim");
                    }
                }
            }
}
