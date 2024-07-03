using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGUILLE : MonoBehaviour
{
    public GameObject antiGravityMushroom;
    public GameObject bouncyGravityMushroom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        antiGravityMushroom.SetActive(true);
        bouncyGravityMushroom.SetActive(true);
    }
}
