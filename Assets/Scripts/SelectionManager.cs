using UnityEngine;
using UnityEngine.Audio;

public class SelectionManager : MonoBehaviour
{

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.volume = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Selectable")
        {
            audio.volume = 0.4f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Selectable")
        {
            audio.volume = 0;
        }
    }
}
