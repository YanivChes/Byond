using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoThumbnailPhill : MonoBehaviour
{

    private GameObject placeHolder;
    private VideoPlayer video;
    private AudioSource audioSource;
    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        audioSource = GetComponent<AudioSource>();
        placeHolder = this.transform.GetChild(0).gameObject;
        GetComponent<MeshRenderer>().enabled = false;
        placeHolder.GetComponent<MeshRenderer>().enabled = true;
    }

    public void SetMaterial(bool isActive)
    {
        if (isActive)
        {
            Invoke("SwitchVideoToTrue", 4f);
            //SwitchVideoToTrue();
            audioSource.volume = 0;
        }
        else
        {
            SwithToVideo(false);
        }
    }
    private void SwitchVideoToTrue()
    {
        SwithToVideo(true);
    }

    private void SwithToVideo(bool isVideo)
    {

        if (isVideo)
        {
            video.time = 0;
        }
        StartCoroutine(SetPlaceHolder(isVideo));
    }

    private IEnumerator SetPlaceHolder(bool isVideo)
    {
        yield return new WaitForSeconds(0.2f);
        audioSource.volume = 1;
        GetComponent<MeshRenderer>().enabled = isVideo;
        placeHolder.GetComponent<MeshRenderer>().enabled = !isVideo;
    }
}