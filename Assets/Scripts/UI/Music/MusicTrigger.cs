
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public GameObject PlayMusic;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "chick") {
            PlayMusic.GetComponent<MiscPlay>().PlayMusicOnTrigger();
        }
    }
}
