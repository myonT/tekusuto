using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public int enemyHP1 = 100;
//	public int enemyHP2 = 100;

	// Use this for initialization
	void Start () {
		Debug.Log ("敵のHPは"+enemyHP1);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHP1 == 0) {
			Debug.Log ("1は倒れた");
		}
	}

	private void OnCollisionEnter(Collision collision){
		enemyHP1--;
		Debug.Log ("敵1のHPは" + enemyHP1);
	}
}


//collider
//衝突した相手のコライダーが保管される。値は、Colliderクラスのインスタンス