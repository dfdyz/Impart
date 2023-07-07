using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskCamCtrl : MonoBehaviour
{
    [SerializeField]
    private Camera Main;
    [SerializeField]
    private Camera self;
    // Start is called before the first frame update
    void Start()
    {
        self.orthographicSize = Main
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
