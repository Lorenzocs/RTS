using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptmouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = worldPoint;
    }
}
