using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        StartCoroutine("changeScene");
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("playScreen");
    }
}
