using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundOnCollision : MonoBehaviour
{
  public AudioClip sound;
  public float volume = 1.0f;
  void OnCollisionEnter(Collision c)
  {
    if (!c.other.gameObject.GetComponent<Player>())
    {
      return;
    }
    this.GetComponent<AudioSource>().PlayOneShot(this.sound, this.volume);
  }
}
