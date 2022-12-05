using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{

    public GameObject daBabyObject;
    public Vector3 babyTrajectory;
    public float babyRate = 1;

    private float nextBabyTime = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(nextBabyTime < Time.time) {
            nextBabyTime = Time.time + (babyRate * Random.Range(1, 2));
            Instantiate(daBabyObject, transform.position, Random.rotation);
        }

        if(Input.GetAxis("Cancel") > 0) {
            Application.Quit();
        }
    }
}
