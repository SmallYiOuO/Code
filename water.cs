using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public Vector3 a,b;
    
    

    // Update is called once per frame
    void Update()
    {
        //遠離玩家一段距離後消失
        a=Cat.caton;
        b=transform.position;
        if(a.y>b.y&&a.y-b.y>=10f)
        {
           
           Destroy (gameObject);
           
            
           
        }
        
    }
}
