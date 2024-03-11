using UnityEngine;

public class FireON : MonoBehaviour
{
    public Animator _anim;
    void Update()
    {
        if (switch1_5._Switch1_5 == 1) {
            _anim.Play("FireAnim");
        }
    }
}
