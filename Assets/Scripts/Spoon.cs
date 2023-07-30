using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{
    [SerializeField] private GameObject PiecePhosp;
    private bool isFull = false;
    [SerializeField] private Spill spill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Phosphorus")
        {
            PiecePhosp.SetActive(true);
            isFull = true;
        }
        if(other.TryGetComponent(out Reaction reaction) && isFull && spill.isSpilled)
        {
            reaction.phosphorus = true;
        }
    }
}
