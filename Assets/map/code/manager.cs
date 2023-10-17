using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public static manager main;
    public Transform startwalksaf;
    public Transform[] walk;

    private void Awake()
    {
        main = this;
    }
}
