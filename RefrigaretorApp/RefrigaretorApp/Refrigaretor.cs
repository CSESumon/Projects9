using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigaretorApp
{
    class Refrigaretor
    {
        private int maxWeight;

public int MaxWeight
{
  get { return maxWeight; }
  set { maxWeight = value; }
}
        private int item;

public int Item
{
  get { return item; }
  set { item = value; }
}
        private int itemWeight;

public int ItemWeight
{
  get { return itemWeight; }
  set { itemWeight = value; }
}

private int totalWeight;

public int TotalWeight1
{
    get { return totalWeight; }
    set { totalWeight = value; }
}
public void TotalWeight()
{
    totalWeight=item* itemWeight;
}


    }
}
