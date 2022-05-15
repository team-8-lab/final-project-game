using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;

    private List<Key.KeyType> keyList;

    public AudioSource keySound;
    public AudioSource doorSound;

    void Awake()
    {
        keyList = new List<Key.KeyType>();
        
    }

    public List<Key.KeyType> GetKeyList()
    {
        return keyList;
    }
         
    public void AddKey(Key.KeyType keyType)
    {
        keyList.Add(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
        OnKeysChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool ContainsKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider other)
    {
        Key key = other.GetComponent<Key>();

        if (key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
            keySound.PlayOneShot(keySound.clip);
        }

        KeyDoor keyDoor = other.GetComponent<KeyDoor>();
        if(keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyType()))
            {
                RemoveKey(keyDoor.GetKeyType());
                doorSound.PlayOneShot(doorSound.clip);
                keyDoor.OpenDoor();
            }
        }
    }
}
