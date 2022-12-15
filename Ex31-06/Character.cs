using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Character
{
    readonly public string name;
    public float hp;
    protected float power;
    public bool resistance;

    public Character(string name,float hp,float power,bool resistance)
    {
        this.name = name;
        this.hp = hp;
        this.power = power;
        this.resistance = resistance;
    }
    public virtual void Attack(Character destination)
    {
        Console.WriteLine($"{this.name}→{destination.name}");
        Console.WriteLine($"{destination.name}に{this.power}ダメージ");
        destination.hp -= this.power;
        Console.WriteLine($"{destination.name}のHPは{destination.hp}");
    }
}