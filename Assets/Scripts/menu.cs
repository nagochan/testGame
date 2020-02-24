using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    bool isEsc = false;
    public GameObject plane,agemono, canvasoya;
    public GameObject[] hontai;
    public GameObject[] back;
    bool pushContinue = false;
    // Start is called before the first frame update
    void Start()
    {
        hontai = GameObject.FindGameObjectsWithTag("hontai");
        back = GameObject.FindGameObjectsWithTag("back");
        foreach(GameObject gmobj in back)
        {
            gmobj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //judge display menu button.
        Esc();
    }

    void Esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || pushContinue)
        {
            pushContinue = false;
            if (!isEsc)
            {
                isEsc = true;
                displayMenu();
                Time.timeScale = 0;
            }
            else
            {
                isEsc = false;
                displayMenu();
                Time.timeScale = 1;
            }
        }
    }

    void displayMenu()
    {
        foreach(GameObject obj in back)
        {
            if (isEsc)
                obj.SetActive(true);
            else
                obj.SetActive(false);
        }
    }

    public void OnClick()
    {
        isEsc = true;
        pushContinue = true;
    }
}