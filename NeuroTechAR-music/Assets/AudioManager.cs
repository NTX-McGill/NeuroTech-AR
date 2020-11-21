using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class AudioManager : MonoBehaviour
{
	public AudioClip[] musicClips;
	private int currentTrack;
	private AudioSource source;

	public Text clipTitleText;
	public Text clipTimeText;

	private int fullLength;
	private int playTime;
	private int seconds;
	private int minutes;

	public Sprite Image1;
	public Sprite Image2;
	public Sprite Image3;



	void start()
	{

		source = GetComponent<AudioSource>();

		//PLAY MUSIC
		PlayMusic();
	}

	public void PlayMusic()
	{

		if (source.isPlaying)
		{

			return;

		}

		currentTrack--;

		if (currentTrack < 0)
		{
			currentTrack = musicClips.Length - 1;

		}

		StartCoroutine("WaitForMusicEnd");
	}


	IEnumerator WaitForMusicEnd()
	{
		while (source.isPlaying)
		{

			playTime = (int)source.time;
			ShowPlayTime();
			yield return null;

		}
	}

	public void NextTitle()
	{
		source.Stop();
		currentTrack++;

		if (currentTrack > musicClips.Length - 1)
		{

			currentTrack = 0;
		}

		source.clip = musicClips[currentTrack];
		source.Play();

		//show title
		ShowCurrentTitle();
		StartCoroutine(WaitForMusicEnd());

	}

	public void PreviousTitle()
	{

		source.Stop();
		currentTrack--;

		if (currentTrack < 0)
		{

			currentTrack = musicClips.Length - 1;
		}

		source.clip = musicClips[currentTrack];
		source.Play();

		//show title
		ShowCurrentTitle();

		StartCoroutine(WaitForMusicEnd());

	}


	public void StopMusic()
	{

		//StopAllCoroutines();
		StopCoroutine("WaitForMusicEnd");

		source.Stop();
	}

	void ShowCurrentTitle()
	{

		clipTitleText.text = source.clip.name;
		fullLength = (int)source.clip.length;

	}

	void ShowPlayTime()
	{

		seconds = playTime % 60;
		minutes = (playTime / 60) % 60;
		

		//clipTimeText.text = minutes + ":" + seconds.ToString("D2") + "/" + (fullLength / 60) % 60) + ":" + (fullLength % 60).ToString("D2");

	}





}
