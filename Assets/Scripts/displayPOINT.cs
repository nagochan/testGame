using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayPOINT : MonoBehaviour
{
    public int point = 0;
    int nowpoint;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        nowpoint = point;
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Point:  " + point;
        if (nowpoint < point)
            StartCoroutine("displaypoint");
        nowpoint = point;
    }

    IEnumerator displaypoint()
    {
        txt.color = new Color(1, 1, 0, 1);
        yield return new WaitForSeconds(0.5f);
        txt.color = new Color(0, 0, 0, 1);
    }
}
