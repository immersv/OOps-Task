using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is A derived class
public class Goblin : MonoBehaviour
{
    private void Start()
    {
        Goblin myGoblin = new Goblin();
        myGoblin.Attack();
        Goblin redGoblin = new RedGoblin();
        redGoblin.Attack();
        Goblin whiteGoblin = new WhiteGoblin();
        whiteGoblin.Attack();
    }
    public virtual void Attack()
    {
        Debug.Log("Goblin Attack");
    }

}

public class RedGoblin: Goblin
{
    public override void Attack()
    {
        Debug.Log("RedGoblin attack");
    }
}

public class WhiteGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("WhiteGoblin attack");
    }
}