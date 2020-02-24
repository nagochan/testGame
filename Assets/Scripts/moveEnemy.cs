using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveEnemy : MonoBehaviour {
	Slider enemySpeed;
	public GameObject slider;
	float speed;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		slider = GameObject.Find("EnemySpeed");
		enemySpeed = slider.GetComponent<Slider>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	}


	private void FixedUpdate()
	{
		speed = enemySpeed.value;
		//transform.Translate(0, 0, -speed);
		rb.AddForce(0, 0, -speed, ForceMode.Force);
		Destroy(this.gameObject, 10);
	}
	void OnTriggerEnter(Collider other)
	{
		Destroy(this.gameObject);
		// 3D同士が接触した瞬間の１回のみ呼び出される処理
	}
}
