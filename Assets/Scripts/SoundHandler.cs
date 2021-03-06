﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundHandler : MonoBehaviour
{
	public static SoundHandler instance;
	public AnimationCurve volumeCurve;
	public AudioSource sineX, sineY, sineZ;

	void Awake ()
	{
		instance = this;
	}
	
	void Update ()
	{
	
	}

	public void Mute(bool noSound)
	{
		if (noSound)
		{
			sineX.volume = 0f;
			sineY.volume = 0f;
			sineZ.volume = 0f;
		}
		else
		{
			sineX.volume = 1.5f;
			sineY.volume = 1.5f;
			sineZ.volume = 1.5f;
		}
	}

	public void AlterFrequenciesByVector3(Vector3 amount)
	{
		sineX.pitch = 1f + 0.4f * amount.x;
		sineY.pitch = 1f + 0.4f * amount.y;
		sineZ.pitch = 1f + 0.4f * amount.z;

		float newVolume = volumeCurve.Evaluate(amount.magnitude/2f);
		sineX.volume = newVolume;
		sineY.volume = newVolume;
		sineZ.volume = newVolume;
	}
}
