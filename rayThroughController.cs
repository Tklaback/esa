using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rayThroughController : MonoBehaviour
{
    Ray myRay;
    Vector3 eyes;
    Vector3 direction;
    Text info;
    // Start is called before the first frame update
    void Start()
    {
        info = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        eyes = GameObject.Find("CenterEyeAnchor").transform.position;
        direction = (GameObject.Find("RightHandAnchor").transform.position - eyes);
        
        RaycastHit hit;
        if (Physics.Raycast(eyes, direction, out hit))
        {
            Transform objectPos = hit.transform.GetComponent<Transform>();
            info.text = objectPos.position.ToString();
        }


    }
}
