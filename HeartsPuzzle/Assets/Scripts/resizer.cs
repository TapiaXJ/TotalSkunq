using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizer : MonoBehaviour {
    public Camera cam;

    // Use this for initialization
    void Start()
    {
        float worldScreenHeight = (float)(cam.orthographicSize * 2.0);
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
        float widthLocalScale = (worldScreenWidth / GetComponent<SpriteRenderer>().sprite.bounds.size.x);
        float heightLocalScale = (worldScreenHeight / GetComponent<SpriteRenderer>().sprite.bounds.size.y);
        transform.localScale = new Vector3(heightLocalScale, heightLocalScale, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}