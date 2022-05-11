using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_KeyHolder : MonoBehaviour
{
    [SerializeField]
    private KeyHolder keyHolder;

    private Transform container;
    private Transform KeyImage;

    private void Awake()
    {
        container = transform.Find("container");
        KeyImage = container.Find("KeyImage");
        KeyImage.gameObject.SetActive(false);
    }

    private void Start()
    {
        keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
    }

    private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        foreach(Transform child in container)
        {
            if (child == KeyImage) continue;
            Destroy(child.gameObject);
        }

        List<Key.KeyType> keyList = keyHolder.GetKeyList();
        for (int i = 0; i < keyList.Count; i++)
        {
            Key.KeyType keyType = keyList[i];
            Transform keyTransform = Instantiate(KeyImage, container);
            KeyImage.gameObject.SetActive(true);
        }
    }
}
