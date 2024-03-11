
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathReload : MonoBehaviour
{
    public Animator anim;
    public GameObject ReloadButton;
    private void Start() {
        ReloadButton.SetActive(false);
    }
private void Update() {
    if (PlayerLive._live == 1) {
        anim.Play("Death");
        ReloadButton.SetActive(true);
    }
}
}
