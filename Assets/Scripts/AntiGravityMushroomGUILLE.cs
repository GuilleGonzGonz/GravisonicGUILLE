using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class AntiGravityMushroomGUILLE : MonoBehaviour
{
    [SerializeField] private AudioClip _gravity;
    [SerializeField] private AudioSource _audioSource;

    public bool activated = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activate()
    {
        activated = true;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (activated)
        {
            var controller = collider.GetComponent<PlayerController>();

            controller.InvertGravity = true;
            controller.StopJump();

            // Plays SFX
            _audioSource.clip = _gravity;
            _audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (activated)
        {
        var controller = collider.GetComponent<PlayerController>();

        controller.InvertGravity = false;

        // stops SFX
        _audioSource.Stop();
        }
    }
}
