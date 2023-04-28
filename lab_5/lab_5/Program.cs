using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

abstract class Forest
{
    public abstract void Plant();

    public abstract void Chop();

    public abstract int CountTrees();
}

class Tree : Forest
{
    private int age;

    public Tree(int age)
    {
        this.age = age;
    }

    public override void Plant()
    {
        Console.WriteLine("A tree has been planted.");
    }

    public override void Chop()
    {
        Console.WriteLine("The tree has been chopped down.");
    }

    public override int CountTrees()
    {
        return 1;
    }
}

class Bush : Forest
{
    private int numberOfBerries;

    public Bush(int numberOfBerries)
    {
        this.numberOfBerries = numberOfBerries;
    }

    public override void Plant()
    {
        Console.WriteLine("A bush has been planted.");
    }

    public override void Chop()
    {
        Console.WriteLine("The bush has been cut down.");
    }

    public override int CountTrees()
    {
        return 0;
    }

    public int CountBerries()
    {
        return numberOfBerries;
    }
}

class Birch : Tree
{
    public Birch(int age) : base(age)
    {
    }

    public void Birchsap()
    {
        Console.WriteLine("Birch sap wa obtained");
    }
}

class PineTree : Tree
{
    public PineTree(int age) : base(age)
    {
    }

    public void DropPinecones()
    {
        Console.WriteLine("Pinecones have been dropped.");
    }
}

class SpruceTree : Tree
{
    public SpruceTree(int age) : base(age)
    {
    }

    public void DropNeedles()
    {
        Console.WriteLine("Needles have been dropped.");
    }
}

class BlueberryBush : Bush
{
    public BlueberryBush(int numberOfBerries) : base(numberOfBerries)
    {
    }

    public void HarvestBerries()
    {
        Console.WriteLine("Berries have been harvested.");
    }
}

class CranberryBush : Bush
{
    public CranberryBush(int numberOfBerries) : base(numberOfBerries)
    {
    }

    public void HarvestBerries()
    {
        Console.WriteLine("Berries have been harvested.");
    }
}

class ForestSimulator
{
    static void Main(string[] args)
    {
        List<Forest> forest = new List<Forest>();

        PineTree pineTree1 = new PineTree(10);
        PineTree pineTree2 = new PineTree(20);
        SpruceTree spruceTree1 = new SpruceTree(30);
        Birch birchTree1 = new Birch(10);
        BlueberryBush blueberryBush1 = new BlueberryBush(51);
        BlueberryBush blueberryBush2 = new BlueberryBush(70);
        CranberryBush cranberryBush1 = new CranberryBush(30);
        CranberryBush cranberryBush2 = new CranberryBush(40);

        forest.Add(pineTree1);
        forest.Add(pineTree2);
        forest.Add(spruceTree1);
        forest.Add(birchTree1);
        forest.Add(blueberryBush1);
        forest.Add(blueberryBush2);
        forest.Add(cranberryBush1);
        forest.Add(cranberryBush2);

        int totalBerries = 0;
        int totalTrees = 0;

        foreach (Forest item in forest)
        {
            if (item is Bush)
            {
                totalBerries += ((Bush)item).CountBerries();
            }

            if (item is Tree)
            {
                totalTrees += item.CountTrees();
            }
        }

        Console.WriteLine("Total number of berries: " + totalBerries);
        Console.WriteLine("Total number of trees: " + totalTrees);


    }

}