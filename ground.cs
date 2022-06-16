using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
   
   
   [SerializeField] GameObject[] groundbody;
   [SerializeField] GameObject[] water;
   public Transform S;
      public Vector3 c;
      int R;
   public void groundp()
   {  
      //生成階梯
      c=S.position;
    int a=Random.Range(0,groundbody.Length);
    GameObject G = Instantiate(groundbody[a],transform);
    G.transform.position=new Vector3(Random.Range(-8f,8.5f),c.y+11f,0f); 
    R=Random.Range(0,10);
    //有五分之一的機率 在階梯上生成水或火
    if(R==0)
    {
      int b=Random.Range(0,water.Length);
      GameObject W = Instantiate(water[b],transform);
      W.transform.position=new Vector3(G.transform.position.x+Random.Range(-1.5f,1.5f),G.transform.position.y+1.5f,0f); 
    }


   }   
    
    
     
}
