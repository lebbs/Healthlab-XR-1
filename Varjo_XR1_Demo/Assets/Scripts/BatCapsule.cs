﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCapsule : MonoBehaviour
{
	[SerializeField]
	public BatCapsuleFollower _batCapsuleFollowerPrefab;

	private void SpawnBatCapsuleFollower()
	{
		var follower = Instantiate(_batCapsuleFollowerPrefab);
		follower.transform.position = transform.position;
		follower.SetFollowTarget(this);
	}

	private void Start()
	{
		SpawnBatCapsuleFollower();
	}
}
