using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	int count = 0;
	int playerHP = 10; 

	void Start () {
		Debug.Log (playerHP);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			if(gameObject.GetComponent<Rigidbody> ().velocity== new Vector3(0,0,0)){
				gameObject.GetComponent<Rigidbody> ().velocity = transform.forward * 50f;
				count++;
				Debug.Log (count);
			}
		}
		if (gameObject.GetComponent<Rigidbody> ().velocity == new Vector3 (0, 0, 0)) {
			transform.Rotate (new Vector3(0, 5f, 0));
		}
	}

	void OnTriggerEnter(Collider other){
		playerHP--;
		Debug.Log ("プレイヤーのHPは" + playerHP);
		if(playerHP == 0){
			Debug.Log ("GameOver");
		}
	}
}
