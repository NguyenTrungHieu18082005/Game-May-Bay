using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // khai bao bien toc do bay     
    public float flySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // lay vi tri cua vien dan
        var newPosotion = transform.position;
        // lay gia tri toa do y cua vien dan hien tai , thoi gian di chuyen giua hai frame, S = time * van toc
        newPosotion.y += Time.deltaTime * flySpeed;
        // cap nhat vi tri moi cho vien dan
        transform.position = newPosotion;
    }
}
