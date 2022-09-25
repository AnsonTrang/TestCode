using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiusRotation : MonoBehaviour
{
    public float speed = 1.0f;
    public float radius = 1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        float x = Mathf.Cos(Time.time * speed);
        float y = Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(x * radius, y * radius, 0);
    }
}
