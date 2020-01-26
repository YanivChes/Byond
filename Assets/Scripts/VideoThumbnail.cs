using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoThumbnail : MonoBehaviour
{

    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.time = 0;
        video.Play();
        Invoke("StopVideo", 0.5f);
    }

    private void StopVideo()
    {
        video.Pause();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
