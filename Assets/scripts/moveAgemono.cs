using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAgemono : MonoBehaviour
{
    [SerializeField] float forawdSpeed = 0.1f; 
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //create Enemy.
        StartCoroutine("createEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        //move Bar.
        barMove();

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

    IEnumerator createEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float randomX = Random.Range(-4, 4);
            Vector3 enemyPos = new Vector3(randomX, 0.5f, -24f);
            GameObject enemyObj = Instantiate(enemy, enemyPos, Quaternion.identity);
            enemyObj.name = "enemy";
        }
    }
}
