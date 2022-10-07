using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAdd : MonoBehaviour
{
    public float cubeForceAmt = 10;

    private Rigidbody cubeRB;

    void Awake() {
        cubeRB = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        cubeRB.AddForce(0, cubeForceAmt, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
