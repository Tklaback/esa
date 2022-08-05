using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetHitPosition : MonoBehaviour
{
    private int cnt = 1;
    public List<Vector3> hits;
    Text info;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.Find("txt").GetComponent<Text>();
    }

    
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;

            Vector2 toVector = hit.transform.position - transform.position;

            if (OVRInput.GetDown(OVRInput.Button.One))
            {
                Transform objectPos = hit.transform.GetComponent<Transform>();
                hits.Add(objectPos.position);
                info.text = hits[cnt].ToString();
                hit.transform.gameObject.GetComponent<AudioSource>().Play();
                cnt++;
            }
     

        }

    }

}
