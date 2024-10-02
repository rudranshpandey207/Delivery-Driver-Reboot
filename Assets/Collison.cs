using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collison : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D other)
  {
        Debug.Log("OUCH!");
  }
  void OnTriggerEnter2D(Collider2D other)
  {
        Debug.Log("Triggered!");
  }
}
