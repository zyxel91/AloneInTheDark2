using UnityEngine;

public class Platform3_2 : MonoBehaviour
{
    public Animator _anim;
    void Update()
    {
        if (Switch3_2._Switch3_2 == 1) {
            _anim.Play("2_Platfmorm3_1Down");
        }
        if (Switch3_2._Switch3_2 == 0) {
            _anim.Play("2_Platfmorm3_1Up");
        }
    }
}
