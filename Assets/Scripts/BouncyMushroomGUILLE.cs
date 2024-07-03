using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class BouncyMushroomGUILLE : MonoBehaviour
{
    //public AntiGravityMushroomGUILLE LinkedGravityMushroom;

    [SerializeField] private AudioClip _gravity;
    [SerializeField] private AudioSource _audioSource;

    public float forceAmount;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Activate(collision);
        //LinkedGravityMushroom.Activate();
    }

    public void Activate(Collision2D activator)
    {

        KinematicObject kinematicObject = activator.collider.GetComponent<KinematicObject>();

        if (kinematicObject != null)
        {
            kinematicObject.Bounce(forceAmount);
        }

        //Rigidbody2D collidedRigidbody = activator.collider.GetComponent<Rigidbody2D>();

        //collidedRigidbody.AddForce(Vector2.up * forceAmount, ForceMode2D.Impulse);


    }

    public void ActivateGravityMushroom()
    {
    }


}
