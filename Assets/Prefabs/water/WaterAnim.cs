using UnityEngine;

public class WaterAnim : MonoBehaviour
{
  public Animator _anim;
    void Update()
    {
        if(LeftSwitchPos.leftSwitch == 0 && RightSwitchPos.RightSwitch == 0 && DawnSwitchPos.DawnSwitch == 0) {
            _anim.Play("WaterFall");
        } else if (LeftSwitchPos.leftSwitch == 1 && RightSwitchPos.RightSwitch == 1 && DawnSwitchPos.DawnSwitch == 1) {
            _anim.Play("WaterOff");
            Destroy(gameObject, 1f);
        }
    }
}
