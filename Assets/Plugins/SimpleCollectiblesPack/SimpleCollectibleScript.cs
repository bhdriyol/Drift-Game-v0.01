﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class SimpleCollectibleScript : MonoBehaviour {

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
	}

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		transform.DOLocalMoveY(transform.localPosition.y + 5, 1f);
		//if(collectEffect)
		//	Instantiate(collectEffect, transform.position, Quaternion.identity);

		StartCoroutine(DestroyCoin());
	}

	IEnumerator DestroyCoin()
	{
		yield return new WaitForSeconds(1f);
        Destroy (gameObject);
    }
}
