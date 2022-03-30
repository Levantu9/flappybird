using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move();
        }
    }
    private void Move()
    {
        rb.velocity = Vector2.up * velocity;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
