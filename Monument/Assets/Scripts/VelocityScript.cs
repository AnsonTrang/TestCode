using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{

    public float moveSpeed = 1;

    private Rigidbody cubeRb;

    void Awake() {
        cubeRb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeRb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0, 0);
    }
}
