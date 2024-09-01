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
}
