using UnityEngine;

public class FuelBatteryDestroy : MonoBehaviour
{
    public Animator anim;
    public AudioSource sound;
    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            sound.Play();
            anim.Play("DestroyAnim");
            FuelBatterCount.Battery++;
            Destroy(gameObject, 0.4f);
        }
    }
}
