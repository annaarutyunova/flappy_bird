using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float speed;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Vector3 move = new Vector3(-1 * speed,0);
        transform.Translate(move);
    }
    
}
