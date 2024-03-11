using UnityEngine;

public class AddLive : MonoBehaviour
{ 
    public Animator _anim;
    AudioSource audioSource;
   private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player"){
    _anim.Play("HeartDestroy");
    audioSource = GetComponent<AudioSource>();
   audioSource.Play();
    Destroy(gameObject, 0.5f);
    PlayerLive._live++;
    }
}
}
