using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=15.0f;
    private float turnSpeed=25.0f;
    private float horizontalinput;
    private float forwardinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput=Input.GetAxis("Horizontal");
        forwardinput=Input.GetAxis("Vertical");
        //n7arkou el karahba l9oddem wele lteli
        transform.Translate(Vector3.forward * Time.deltaTime*speed*forwardinput);
        //n7arkou el karahba lel imin wele isar
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalinput);

        
    }
}
