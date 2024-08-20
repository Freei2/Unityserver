using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird
{
    int wings = 2;
    int legs  = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }

    public void sing()
    {
        Debug.Log("I am singing.");
    }
}

public class Buffalo
{
    int horns = 2;
    int legs  = 2;

    public void eat()
    {
        Debug.Log("I am eating");
    }
    
    public void scream()
    {
        Debug.Log("I am screaming");
    }
}
public class Crow : Bird
{
   public void steal()
    {
        Debug.Log("I am stealing");
    }
   Bomb bomb01 = new Bomb();
   public void attack()
    {
        bomb01.explode();
    }
}
public class Bomb
{
    public void explode()
    {
        Debug.Log("Boommmm!!!");
    }
}

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()    
    {
        Bird sompong = new Bird();
        sompong.fly();

        Bird sommai = new Bird();
        sommai.sing();

        Buffalo somchai = new Buffalo();
        somchai.eat();
        
        Buffalo som = new Buffalo();
        som.scream();

        Crow somjid = new Crow();
        somjid.sing();

        Crow somlod = new Crow();
        somlod.steal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
