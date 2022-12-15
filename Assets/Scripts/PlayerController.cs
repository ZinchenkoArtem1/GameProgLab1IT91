using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
 public float Speed = 20f;
 private Rigidbody2D rb;

 // Start is called before the first frame update
 void Start()
 {
 rb = GetComponent<Rigidbody2D>();
 }
 // Update is called once per frame
 void Update()
 {
 float moveX = Input.GetAxis("Horizontal");// -1 to 1
 rb.MovePosition(rb.position + Vector2.right*moveX*Speed*Time.deltaTime); //
 }
}