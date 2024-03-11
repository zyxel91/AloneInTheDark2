using UnityEngine;

public class KeyCollect : MonoBehaviour
{
   
    AudioSource audioSource;
    public static int _keys;
    public Animator _anim;
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Player"){
    audioSource = GetComponent<AudioSource>();
    audioSource.Play();
    _anim.Play("KeyDestroyAnim");
    Destroy(gameObject, 0.4f);
    _keys++;
    if (_keys > 1) {
        _keys = 1;
    }
    }
}
}

