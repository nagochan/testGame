using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTXTColor : MonoBehaviour
{
    Text color;
    bool colorbool = false;
    // Start is called before the first frame update
    void Start()
    {
        color = this.GetComponent<Text>();
        StartCoroutine("ChangeColor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (colorbool)
            {
                color.color = new Color(1.0f, 0, 0, 1);
                colorbool = false;
                Debug.LogError("change!");
            }
            else
            {
                color.color = new Color(1, 1, 1, 1);
                colorbool = true;
            }
        }
    }
}
