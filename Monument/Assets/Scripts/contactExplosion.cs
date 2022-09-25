using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col) {
        if(col != null) {
            Rigidbody colRgbd = col.gameObject.GetComponent<Rigidbody>(); 
            Debug.Log(colRgbd);
        
            if (colRgbd){
                colRgbd.isKinematic = false;
            }
        }

    }
}
