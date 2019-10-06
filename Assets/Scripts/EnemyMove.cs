using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPos;
    public float xRange;
    public float moveDir = 1.0f;
    public float speed;

    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Time.deltaTime * moveDir, gameObject.transform.position.y, gameObject.transform.position.z );
        if (gameObject.transform.position.x > startPos.x + xRange)
        {
            moveDir = -1.0f;
        }
        if (gameObject.transform.position.x < startPos.x - xRange)
        {
            moveDir = 1.0f;
        }
    }
}
