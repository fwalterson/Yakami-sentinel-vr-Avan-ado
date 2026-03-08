using UnityEngine;

public class SomBarco : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void TocarSom()
    {
        audioSource.Play();
    }
}