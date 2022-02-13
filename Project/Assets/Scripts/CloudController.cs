using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float speed;
    Vector2 target;
    RectTransform rectTransform;
    public bool isClone = false;

    void Start()
    { 
        DontDestroyOnLoad(this);
        rectTransform = GetComponent<RectTransform>();
        int y = Random.Range(-200, 370);
        speed = Random.Range(30, 100);
        rectTransform.anchoredPosition = new Vector2(1080, y);
        target = new Vector2(-1080, y);
    }

    void Update()
    {
        if (isClone)
        {
            if (rectTransform.anchoredPosition == target)
            {
                Destroy(this.gameObject);
            }
            rectTransform.anchoredPosition = Vector2.MoveTowards(rectTransform.anchoredPosition, target, speed * Time.deltaTime);
        }
    }
}
