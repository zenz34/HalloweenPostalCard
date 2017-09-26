using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFade : MonoBehaviour {

	public float Duration = 2.0f;
	float elapse;

	void Start () {
		SetAlpha(0);
	}

	void SetAlpha (float a) {
		var sp = GetComponent<SpriteRenderer>();
		var c = sp.color;
		c.a = a;
		sp.color = c;
	}

	void Update () {
		if (elapse < Duration) {
			elapse += Time.deltaTime;
			SetAlpha(elapse / Duration);
		}
	}
}
