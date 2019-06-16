using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
  public string verticalInputName = "Vertical";
  public string horizontalInputName = "Horizontal";
  public float speed = 1.0f;
  public float turnSpeed = 1.0f;


  private Rigidbody _rigidbody;

  void Awake()
  {
    this._rigidbody = this.GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    this._rigidbody.AddRelativeForce(-Vector3.forward * Input.GetAxis(this.verticalInputName) / Time.fixedDeltaTime * speed);
    this._rigidbody.AddTorque(Vector3.up * Input.GetAxis(this.horizontalInputName) / Time.fixedDeltaTime * turnSpeed);
  }
}
