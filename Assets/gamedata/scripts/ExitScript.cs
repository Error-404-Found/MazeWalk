﻿using System.Collections;
using UnityEngine;

public class ExampleClass : MonoBehaviour {
     void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}