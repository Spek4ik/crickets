using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
