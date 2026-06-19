using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip clickSound;

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
    private void OnMouseDown()
{
    GetComponent<ButtonSound>().PlayClickSound();
}
}