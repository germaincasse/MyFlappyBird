using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject leftWall;
    public float velocity = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)
            || (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)) {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject == leftWall)
            gameManager.GameOver();
    }
}
