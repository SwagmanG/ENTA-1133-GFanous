using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerAssignment.Player_Code
{
    public abstract class Item
    {
        public abstract int Durability { get; }
        public abstract int MaxDamage { get; }
        public abstract int MinDamage { get; }
        public abstract string? Name { get; }

    }

    public class RustyPipe : Item
    {      
        public override int Durability { get; } = 5;
        public override int MaxDamage { get; } = 35;
        public override int MinDamage { get; } = 20;
        public override string? Name { get; } = "Rusty Pipe";
    }
    public class RustyKitchenKnife : Item
    {       
        public override int Durability { get; } = 3;
        public override int MaxDamage { get; } = 40;
        public override int MinDamage { get; } = 25;
        public override string? Name { get; } = "Rusty Kitchen Knife";
    }
    public class Bedpost : Item
    {       
        public override int Durability { get; } = 2;
        public override int MaxDamage { get; } = 20;
        public override int MinDamage { get; } = 10;
        public override string? Name { get; } = "Bedpost";
    }
    public class WoodenBat : Item
    {     
        public override int Durability { get; } = 3;
        public override int MaxDamage { get; } = 20;
        public override int MinDamage { get; } = 10;
        public override string? Name { get; } = "Wooden Bat";
    }
    public class OldGuitar : Item
    {    
        public override int Durability { get; } = 2;
        public override int MaxDamage { get; } = 30;
        public override int MinDamage { get; } = 15;
        public override string? Name { get; } = "Old Guitar";
    }
    public class GlassTubeLight : Item
    {
        public override int Durability { get; } = 1;
        public override int MaxDamage { get; } = 100;
        public override int MinDamage { get; } = 75;
        public override string? Name { get; }    = "Glass Light Tube";
    }
    public class WoodenChair : Item
    {
       
        public override int Durability { get; } = 2;
        public override int MaxDamage { get; } = 20;
        public override int MinDamage { get; } = 10;
        public override string? Name { get; } = "Wooden Chair";
    }
    public class MetalPanLid : Item
    {
      
        public override int Durability { get; } = 7;
        public override int MaxDamage { get; } = 30;
        public override int MinDamage { get; } = 17;
        public override string? Name { get; } = "Metal Pan Lid";
    }
    public class PlywoodBoard : Item
    {

        public override int Durability { get; } = 3;
        public override int MaxDamage { get; } = 40;
        public override int MinDamage { get; } = 20;
        public override string? Name { get; } = "Plywood Board";
    }
    public class Olanzapine : Item
    {
       
        public override int Durability { get; } = 3;
        public override int MaxDamage { get; } = 50;
        public override int MinDamage { get; } = 20;
        public override string? Name { get; } = "Olanzapine";
    }
    public class Risperidone : Item
    {
        public override int Durability { get; } = 1;
        public override int MaxDamage { get; } = 75;
        public override int MinDamage { get; } = 50;
        public override string? Name { get; } = "Risperidone";

    }
    public class Clozapine : Item
    {
        public override int Durability { get; } = 5;
        public override int MaxDamage { get; } = 25;
        public override int MinDamage { get; } = 10;
        public override string? Name { get; }    = "Clozapine";
    }
}

