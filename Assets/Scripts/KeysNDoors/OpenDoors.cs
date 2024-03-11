using UnityEngine;

public class OpenDoors : MonoBehaviour
{
   
    AudioSource audioSource;
    public Animator _anim;
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player" && KeyCollect._keys == 1){
    audioSource = GetComponent<AudioSource>();
    audioSource.Play();
   _anim.Play("OpenDoor");
    Destroy(gameObject, 0.4f);
    KeyCollect._keys--;
    }
}
}
