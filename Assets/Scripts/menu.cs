using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    bool isEsc = false;
    public GameObject plane,agemono, canvasoya;
    public GameObject haikei;
    public GameObject[] hontai;
    public GameObject[] back;
    
    int count = 3;
    // Start is called before the first frame update
    void Start()
    {
        hontai = GameObject.FindGameObjectsWithTag("hontai");
        back = GameObject.FindGameObjectsWithTag("back");
        foreach(GameObject gmobj in back)
        {
            gmobj.SetActive(false);
        }
        StartCoroutine("countDown");
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            if (!isEsc) {
                isEsc = true;
                foreach(GameObject gmobj in hontai)
                {
                    gmobj.SetActive(false);
                }
                foreach(GameObject gmobj in back)
                {
                    Debug.Log(gmobj.active);
                    gmobj.SetActive(true);
                }
                Debug.Log(back.Length);
            }
            else {
                isEsc = false;
                StartCoroutine("countDown");
                foreach(GameObject gmobj in hontai)
                {
                    gmobj.SetActive(true);
                }
                foreach(GameObject gmobj in back)
                {
                    gmobj.SetActive(false);
                }
            }
        }
    }
}