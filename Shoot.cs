using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Gun;

    public Animator anim;


    public GameObject Bullet;

    public float bulletspeed;
    public float fireRate;
    float  ReadyForNextShot;
    static extern bool SetCursorPos(int X, int Y);


    Vector2 direction;
    public Transform shootpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      int xPos = 30, yPos = 1000;   
      Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      direction = mousePos - (Vector2)Gun.position;
      FaceMouse();   

      if(Input.GetButtonDown("Fire1"))
      {
        if(Time.time > ReadyForNextShot)
        {
            ReadyForNextShot = Time.time + 1/fireRate;
            shoot();
        }
      } 
    }
    void FaceMouse()
{
    Gun.transform.right = direction;
}

void shoot()
{
    GameObject bulletin =  Instantiate(Bullet,shootpoint.position,shootpoint.rotation);
    bulletin.GetComponent<Rigidbody2D>().AddForce(bulletin.transform.right * bulletspeed);
    anim.SetTrigger("Recoil");
    Destroy(bulletin,1.6f);
}
}

