﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBugPatch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
    }
}