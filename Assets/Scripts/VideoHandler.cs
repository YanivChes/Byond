using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{
    public List<VideoPlayer> videos;
    //public List<Material> thumbnails;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered");
        if(other.tag == "Player")
        {
            Debug.Log("Player Entered");
            SetVideoState(true);
            //SetMaterialState(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SetVideoState(false);
        //SetMaterialState(true);
    }

    private void SetVideoState(bool isPlay)
    {
        foreach(VideoPlayer video in videos)
        {
            if (isPlay)
                video.Play();
            else video.Stop();

            VideoThumbnailPhill phillController = video.GetComponent<VideoThumbnailPhill>();
            if (phillController)
            {
                phillController.SetMaterial(isPlay);
            }
        }
    }

    //private void SetMaterialState(bool isShown)
    //{
    //    foreach (Material thumbnail in thumbnails)
    //    {
    //        if (isShown)
    //            thumbnail.
    //        else

    //    }
    //}

}
