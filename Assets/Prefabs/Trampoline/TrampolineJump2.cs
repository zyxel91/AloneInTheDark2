using UnityEngine;

public class TrampolineJump2 : MonoBehaviour
{
   public Rigidbody2D PlayerHere;
   public Animator anim;
   public float speed = 24f;
   public GameObject textAct;
     
     private void OnCollisionEnter2D(Collision2D collision) {
      if(collision.gameObject.tag == "Player" && ButtonTramp2.Button_2 == 0) {
            textAct.SetActive(true);
        }
        if(collision.gameObject.tag == "Player" && ButtonTramp2.Button_2 == 1) {
            anim.Play("JumpAnim");
            
            PlayerHere.AddForce((Vector2.up) * speed, ForceMode2D.Impulse);
            
        }
        
     }
     private void OnCollisionExit2D(Collision2D collision) {
      if(collision.gameObject.tag == "Player" && ButtonTramp2.Button_2 == 0) {
            textAct.SetActive(false);
        }
        if(collision.gameObject.tag == "Player" && ButtonTramp2.Button_2 == 1) {
                anim.Play("JumpAnimReturn");
        }
     }
}