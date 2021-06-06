using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newpos;

        newpos = new Vector2(1, 0) * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(newpos);
    }
}
