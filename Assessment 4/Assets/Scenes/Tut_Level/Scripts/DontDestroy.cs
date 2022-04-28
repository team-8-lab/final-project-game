using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public string objectID;

    void Awake()
    {
        objectID = name + transform.position.ToString();
    }

    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++)
        {
            if(Object.FindObjectsOfType<DontDestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<DontDestroy>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {

    }
}
