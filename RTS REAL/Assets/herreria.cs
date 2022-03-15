using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herreria : MonoBehaviour
{


    // Start is called before the first frame update
    [SerializeField] private Edificios edi;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        edi.edificio = 2;
    }

    
}
