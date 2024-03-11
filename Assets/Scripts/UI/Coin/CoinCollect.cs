
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    AudioSource audioSource;
    public Animator _anim;
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player"){
   audioSource = GetComponent<AudioSource>();
   audioSource.Play();
   _anim.Play("CoinCollected");
    Destroy(gameObject, 0.4f);
    CoinCount.coins++;
    }
}
}
