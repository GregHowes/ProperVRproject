using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEscript : MonoBehaviour
{
    public GameObject PressE;

    private void OnTriggerEnter(Collider other)
    {

        {
            PressE.SetActive(true);

        }
    }
}
