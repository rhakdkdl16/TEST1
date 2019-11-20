using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    [SerializeField] float startPosition;
    [SerializeField] float endPosition;
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1*speed*Time.deltaTime,0,0);
        if(transform.localPosition.x <= endPosition)
        {
            transform.localPosition = new Vector2(startPosition,transform.localPosition.y);
        }
        
    }
}
