using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event EventHandler OnClickedCloud;


    private void Update()
    {
        DedectionCloud();
    }
    void DedectionCloud()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Ekrana dokunulduğunda
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                // Raycast bir objeyi hedef aldığında
                GameObject hitObject = hit.transform.gameObject;
                Debug.Log("Hit object: " + hitObject.name);
                OnClickedCloud?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
