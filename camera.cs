using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public Transform Cat;
 public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
       //使相機和邊界跟隨角色的y軸移動
       Vector3 position = transform.position ;
      position.y = (Cat.position + offset).y;
      transform.position = position ; 
    }
}
