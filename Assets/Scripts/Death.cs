using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
  void OnTriggerEnter(Collider c)
  {
    SceneManager.LoadScene(c.transform.root.gameObject.name + "-lost");
  }
}
