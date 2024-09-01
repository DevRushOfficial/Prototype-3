using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _playerAnimator;

    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    public void TriggerJumpAnimation()
    {
        _playerAnimator.SetTrigger("Jump_trig");
    }

    public void TriggerDeathAnimation()
    {
        _playerAnimator.SetBool("Death_b", true);
        _playerAnimator.SetInteger("DeathType_int", 1);
    }
}
