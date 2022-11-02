using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  private Rigidbody2D _rb;
  
  // Start is called before the first frame update
  void Start() {
    _rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey (KeyCode.LeftArrow)) {
      _rb.AddForce(Vector2.left); }
    if (Input.GetKey (KeyCode.RightArrow)) {
      _rb.AddForce(Vector2.right); }
    if (Input.GetKey (KeyCode.UpArrow)) {
      _rb.AddForce(Vector2.up); }
    if (Input.GetKey (KeyCode.DownArrow)) {
      _rb.AddForce(Vector2.down); }
  }
}
