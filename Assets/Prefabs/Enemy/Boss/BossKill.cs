
using UnityEngine;

public class BossKill : MonoBehaviour
{
     AudioSource audioSource;
     public Animator _anim;

     private int _fireCount;
    
   private void OnCollisionEnter2D(Collision2D collision) {
   if ( collision.gameObject.tag == "Fire") {
     //_anim.Play("Death");
   audioSource = GetComponent<AudioSource>();
   audioSource.Play(1);
   _fireCount++;
   //Destroy(gameObject, 0.4f);
   }
   }
   private void Update() {
    if (_fireCount == 50) {
      _anim.Play("BossDeath");
      Destroy(gameObject, 0.4f);
    }
   }

}
