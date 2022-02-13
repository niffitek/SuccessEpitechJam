using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudSpawner : MonoBehaviour
{
    public GameObject prefab;

    private string[] sprites = {
        "Clouds/Cloud1",
        "Clouds/Cloud2",
        "Clouds/Cloud3",
    };

    IEnumerator Start()
    {
        DontDestroyOnLoad(this);
        while (true)
        {
            SpawnCloud();
            yield return new WaitForSeconds(Random.Range(1,5));
        }
    }

    void SpawnCloud()
    {
        int i = Random.Range(0, 3);
        
        var loadedSprite = Resources.Load<Sprite>(sprites[i]);
        GameObject newObject = Instantiate(prefab);
        newObject.GetComponent<CloudController>().isClone = true;
        newObject.GetComponent<Image>().sprite = loadedSprite;
        newObject.transform.parent = GameObject.Find("Canvas").transform;
        newObject.transform.SetSiblingIndex(0);
    }
}
