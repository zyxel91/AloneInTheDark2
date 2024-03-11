
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
     AudioSource audioSource;
     public Animator _anim;
     private int _fireCount = 0;
    
   private void OnCollisionEnter2D(Collision2D collision) {
   if ( collision.gameObject.tag == "Fire") {
    // _anim.Play("Death");
   audioSource = GetComponent<AudioSource>();
   audioSource.Play();
   //Destroy(gameObject, 0.4f);
   _fireCount++;
   }
   }
private void Update() {
     if(_fireCount == 2) {
     _anim.Play("Death");
     Destroy(gameObject, 0.4f);
     }
}
}
