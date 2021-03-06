using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMove : MonoBehaviour{

    public float speed;
    public float destroy;

    private void Start()
    {
        Destroy(gameObject, destroy);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
