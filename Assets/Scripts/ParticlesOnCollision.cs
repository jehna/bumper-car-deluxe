using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesOnCollision : MonoBehaviour
{
  public Transform prefab;
  void OnCollisionEnter(Collision c)
  {
    if (!c.other.gameObject.GetComponent<Player>())
    {
      return;
    }
    Transform newParticle = GameObject.Instantiate(this.prefab);
    newParticle.position = c.GetContact(0).point;
  }
}
