using UnityEngine;

public class MiscPlay : MonoBehaviour
{
    public AudioClip myClip;
    public AudioClip myClip2;
    public AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        audioSource.clip = myClip;
        audioSource.Play();
    }
    public void PlayMusicOnTrigger()
    {
         audioSource.clip = myClip2;
         audioSource.Play();
    }
}
