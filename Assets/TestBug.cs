using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBug : MonoBehaviour
{

    private float nextActionTime = 1f;
    public float period = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextActionTime)
        {
            nextActionTime += period;
            PrintChild(transform);
        }
        
    }

    private void PrintChild(Transform root)
    {
        Debug.Log(root.name + ", x" + root.eulerAngles.x + ", y" + root.eulerAngles.y + ", z" + root.eulerAngles.z);
        foreach (Transform child in root)
        {
            PrintChild(child);
        }


    }
}
     
