using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour {
	[SerializeField] float enemySpeed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, -enemySpeed);
		Destroy(this.gameObject, 10);
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("kill me!");
		Destroy(this.gameObject);
		// 3D同士が接触した瞬間の１回のみ呼び出される処理
	}
}
