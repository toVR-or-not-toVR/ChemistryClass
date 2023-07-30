using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaction : MonoBehaviour
{
    public bool phosphorus = false;
    public bool bromine = false;
    [SerializeField] private ParticleSystem particleSystem;


    private void LateUpdate()
    {
        if (phosphorus && bromine)
        {
            particleSystem.Play();
            phosphorus = false;
            bromine = false;
        }
    }
}
