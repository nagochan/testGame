using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveEnemy : MonoBehaviour {
	Slider enemySpeed;
	public GameObject slider,lifeobj,pointobj;
	displayLIFE displaylife;
	displayPOINT point;
	float speed;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		slider = GameObject.Find("EnemySpeed");
		lifeobj = GameObject.Find("LIFE");
		pointobj = GameObject.Find("Point");
		displaylife = lifeobj.GetComponent<displayLIFE>();
		point = pointobj.GetComponent<displayPOINT>();
		enemySpeed = slider.GetComponent<Slider>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Destroy(this.gameObject, 10);
		if (transform.position.z < -55)
		{
			//cut back life
			displaylife.life -= 1;
			Destroy(gameObject);
		}
	}


	private void FixedUpdate()
	{
		speed = enemySpeed.value;
		//transform.Translate(0, 0, -speed);
		rb.AddForce(0, 0, -speed, ForceMode.Force);
	}
	void OnTriggerEnter(Collider other)
	{
		point.point += 10;
		Destroy(this.gameObject);
		// 3D同士が接触した瞬間の１回のみ呼び出される処理
	}
}
