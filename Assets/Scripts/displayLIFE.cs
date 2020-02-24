using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class displayLIFE : MonoBehaviour
{
    [SerializeField] public int life = 3;
    int lifenow;
    Text lifestr;
    // Start is called before the first frame update
    void Start()
    {
        lifestr = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lifestr.text = "LIFE:  " + life;
        if (life < lifenow)
            StartCoroutine("changeColor");
        if (life <= 0)
            SceneManager.LoadScene("GameOver");
        lifenow = life;
    }

    IEnumerator changeColor()
    {
        lifestr.color = new Color(1, 0, 0, 1);
        yield return new WaitForSeconds(0.5f);
        lifestr.color = new Color(0, 0, 0, 1);
    }
}
