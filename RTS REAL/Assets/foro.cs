using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foro : MonoBehaviour
{

    [SerializeField] private Edificios edi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        edi.edificio = 0;
    }
}
