﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kakuniMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
        }

    }
}
