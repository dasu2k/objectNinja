using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLogic : MonoBehaviour
{

    public ParticleSystem targetParticles;

    // To give each different object different scores
    public int targetPoints;

    // To get the score attribute in the canvas and to update it
    private Score sc;

    // To get the 'isPaused' attribute
    private Menu menu;

    void Start(){
        
        sc = FindObjectOfType<Score>();
        menu = FindObjectOfType<Menu>();
        Destroy(gameObject , 5);
    }

    void OnMouseDown(){
        if(!menu.isPaused)
        {
            // create the effect & update the score -> destroy the object;
            Instantiate(targetParticles, transform.position,Quaternion.identity);
            sc.UpdateScore(targetPoints);
            Destroy(gameObject);
        }
    }
}
