using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieValue : MonoBehaviour
{
    public Text valueBanner;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, 0.25f)){
            valueBanner.text = "5";
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.25f)){
            valueBanner.text = "2";
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 0.25f)){
            valueBanner.text = "4";
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 0.25f)){
            valueBanner.text = "3";
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 0.25f)){
            valueBanner.text = "6";
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, 0.25f)){
            valueBanner.text = "1";
        }
    }
}
