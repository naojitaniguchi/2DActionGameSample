using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed;
    private bool grounded = false;
    public GameObject gameOverImage;
    // Start is called before the first frame update
    void Start()
    {
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveSpeed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed * -1.0f;
                gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveSpeed * -1.0f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log("OnCollisionEnter2D");
        if ( col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        if (col.gameObject.tag == "Enemy")
        {
            gameOverImage.SetActive(true);
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        //Debug.Log("OnCollisionStay2D");
        //Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        //Debug.Log("OnCollisionExit2D");
        if (col.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
