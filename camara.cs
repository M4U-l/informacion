using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject CamaraZoom;
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWhell") != 0) 
        {
            transform.localPosition += Vector3.forward * Input.GetAxis("Mouse ScrollWhell") * 200;
            {
                RaycastHit hit;
                Ray ray = this.transform.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                Vector3 desiredPosition;

                if (Physics.Raycast(ray, out hit))
                {
                    desiredPosition = hit.point;
                }
                else
                {
                    desiredPosition = transform.position;
                }

                float distance = Vector3.Distance(desiredPosition, transform.position);
                Vector3 direction = Vector3.Normalize(desiredPosition - transform.position) * (distance * Input.GetAxis("Mouse ScrollWhell"));

                transform.position += direction;
            }
        }
    }
}
