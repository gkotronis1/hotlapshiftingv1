using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour

{
    
[SerializeField] private Rigidbody2D frontTireRB;
[SerializeField] private Rigidbody2D rearTireRB;
[SerializeField] private float speed = 150f;

private float moveInput;



private void Update()
{
    moveInput = Input.GetAxisRaw("Horizontal");

}
private void FixedUpdate()
{
    frontTireRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
    rearTireRB.AddTorque(-moveInput * speed * Time.fixedDeltaTime);
}

}