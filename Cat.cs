using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : MonoBehaviour
{
    float moveup=8f;
    public Rigidbody2D catbody;
    GameObject ground;
    GameObject WF;
    float timea=-1f;
    float scores=0f;
    [SerializeField]Text scoretext;
    
    // Start is called before the first frame update
    void Start()
    {
     
     
    }
    static public Vector3 caton;
    // Update is called once per frame
    void Update()
    {
      caton=transform.position;
      //角色移動
      if(Input.GetKey(KeyCode.A))  
     {
      transform.Translate(-moveup*Time.deltaTime,0,0);   
     }   
     else if(Input.GetKey(KeyCode.D)) 
     {
      transform.Translate(moveup*Time.deltaTime,0,0);   
     }  
    }
     
     
    
       
        
      
      
      void OnCollisionEnter2D(Collision2D other) 
       {
         //碰到地面向上彈跳
         if(Time.time-timea>=1f)
         {
         timea=Time.time;
         if (Physics2D.Raycast(transform.position, Vector2.down,0.5f))
         {
           if(other.gameObject.tag=="ground")
         {
           Debug.Log(3);
           catbody.AddForce(new Vector2(0,15),ForceMode2D.Impulse);
         }
         //碰到損壞的地面一次後地面消失
         else if(other.gameObject.tag=="broken")
         {
           Debug.Log(3);
           catbody.AddForce(new Vector2(0,15),ForceMode2D.Impulse);       
           ground=other.gameObject;
           ground.GetComponent<BoxCollider2D>().enabled=false;
           ground.GetComponent<SpriteRenderer>().enabled=false;
         }
         }
         

         }
         
         
       }
        
        //撞到邊際線傳送到另一邊
        void OnTriggerEnter2D(Collider2D well)    
         {
           Vector2 high =transform.position;
           
          if(well.gameObject.tag=="lwell")
         {
           Debug.Log(4);
           high=new Vector2(10.53f,high.y);
           transform.position=high;
         }
         else if(well.gameObject.tag=="rwell")
         {
           Debug.Log(5);
            high=new Vector2(-9.08f,high.y);
           transform.position=high;
         }
         //碰到水加分 碰到火扣分
         if(well.gameObject.tag=="water")
         {     
           WF=well.gameObject;
           scores=scores+1f;
           WF.GetComponent<BoxCollider2D>().enabled=false;
           WF.GetComponent<SpriteRenderer>().enabled=false;
           scoretext.text="Score  "+scores;
         }
         else if(well.gameObject.tag=="fire")
         {     
           WF=well.gameObject;
           scores=scores-1f;
           WF.GetComponent<BoxCollider2D>().enabled=false;
           WF.GetComponent<SpriteRenderer>().enabled=false;
           scoretext.text="Score  "+scores;
         }
        }
}
         
         
     
         

    
    

