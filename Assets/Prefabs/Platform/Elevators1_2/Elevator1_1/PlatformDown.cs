
using UnityEngine;

public class PlatformDown : MonoBehaviour
{
    public Animator _anim;
    void Update()
    {
        if (LeftPlatSwitch.leftPlatSwitch == 1 && RightPlatSwitch.rightPlatSwitch == 1) {
            _anim.Play("PlatformDown");
        }
    }
}
