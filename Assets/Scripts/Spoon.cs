using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoon : MonoBehaviour
{
    [SerializeField] private GameObject PiecePhosp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Phosphorus")
        {
            PiecePhosp.SetActive(true);
        }
    }
}
