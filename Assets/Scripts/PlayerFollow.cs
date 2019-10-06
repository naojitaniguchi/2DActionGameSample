using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    public float xRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( player.transform.position.x  < gameObject.transform.position.x - xRange )
        {
            gameObject.transform.position = new Vector3(player.transform.position.x + xRange, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (player.transform.position.x > gameObject.transform.position.x + xRange)
        {
            gameObject.transform.position = new Vector3(player.transform.position.x - xRange, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
