using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed;
     public float jumphieght;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask whatisground;
    private bool grounded; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(Spacebar) && grounded) {
        Jump();
      } 
        
      if(Input.GetKey(L)) {
        GetComponent<Rigitbody2D>().velocity= new Vector2(-movespeed, GetComponent<Rigitbody2D>().velocity.y);
         if(GetComponent<SpriteRenderer>()!=null){
            GetComponent<SpriteRenderer>().flipx= true;
         }
      } 
      if(Input.GetKey(R)) {
        GetComponent<Rigitbody2D>().velocity= new Vector2(-movespeed, GetComponent<Rigitbody2D>().velocity.y);
          if(GetComponent<SpriteRenderer>()!=null){
            GetComponent<SpriteRenderer>().flipx= false;
      }  
        
      void Jump(){

       Getcomponent<Rigitbody2D>().velocity= new Vector2( Getcomponent<Rigitbody2D>().velocity.x, jumphieght);  
     }
       void Fixedupdat(){

        grounded = Physics2D.overlapcircle(groundcheck.position, groundcheckradius,whatisground);
     }
    
   

      }
   
}
}