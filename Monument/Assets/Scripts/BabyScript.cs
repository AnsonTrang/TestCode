using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * (25f * Random.Range(0.5f, 2)), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "Player"){
            GetComponent<Rigidbody>().AddForce(Vector3.up * (1f * Random.Range(0.5f, 2)), ForceMode.Impulse);
        }   
    }
}
