using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    public float minX, maxX, minY, maxY;
    float clipX, clipY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clipX = Mathf.Clamp(player.position.x, minX, maxX);
        clipY = Mathf.Clamp(player.position.y, minY, maxY);
        transform.position =new Vector3(clipX, clipY, transform.position.z);
    }
}
