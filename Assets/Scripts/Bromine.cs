using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bromine : MonoBehaviour
{
    [SerializeField] private Spill spill;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Reaction reaction) && spill.isSpilled)
        {
            reaction.bromine = true;
        }
    }

}
