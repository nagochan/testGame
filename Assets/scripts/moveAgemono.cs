using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveAgemono : MonoBehaviour
{
    [SerializeField] float forawdSpeed = 0.1f;
    GameObject slider;
    Slider widthSlider;
    float barWidth;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //create Enemy.
        StartCoroutine("createEnemy");

        //get Slider.
        slider = GameObject.Find("BarWidth");
        widthSlider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //move Bar.
        barMove();

        //Change Bar Width.
        changeWidth();
    }

    void barMove()
    {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(-forawdSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(forawdSpeed, 0, 0);
        }
    }

    void changeWidth()
    {
        // get slider value & change bar width.
        barWidth = widthSlider.value;
        transform.localScale = new Vector3(barWidth, 1, 1);
    }

    IEnumerator createEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float randomX = Random.Range(-4, 4);
            Vector3 enemyPos = new Vector3(randomX, 0.5f, -15f);
            GameObject enemyObj = Instantiate(enemy, enemyPos, Quaternion.identity);
            enemyObj.name = "enemy";
        }
    }
}
