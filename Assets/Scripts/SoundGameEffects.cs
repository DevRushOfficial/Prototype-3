using UnityEngine;

public class SoundGameEffects : MonoBehaviour
{
    private AudioSource _playAudio;

    [SerializeField]
    private AudioClip _crashSound;
    [SerializeField]
    private AudioClip _jumpSound;

    void Start() => _playAudio = GetComponent<AudioSource>();

    public void PlayCrashSound()
    {
        _playAudio.PlayOneShot(_crashSound, 1.0f);
    }

    public void PlayJumpSound()
    {
        _playAudio.PlayOneShot(_jumpSound, 1.0f);
    }
}
