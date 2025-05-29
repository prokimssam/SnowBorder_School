using UnityEngine;
using UnityEngine.Audio;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticleSystem;
    [SerializeField] private AudioClip snowSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            audioSource.PlayOneShot(snowSound); 
            dustParticleSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            dustParticleSystem.Stop();
        }
    }
}
