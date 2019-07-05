using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMove : MonoBehaviour
{
	private float speed = 2.5f;
	public GameObject player;

	void Start() {
		
	}

	void Update()
	{
		float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		player.transform.Translate(x, 0, y);
	}
}
