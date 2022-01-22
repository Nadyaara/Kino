using System;
using System.Collections.Generic;
using System.Text;
using Cinema.Model;

namespace Cinema.View_Model
{
    public class Cafe
    {
        int checkCounter = 0;
        public List<Dop> myMeny; 

        // продажа
        public CheckEda SellItem(Dop itemToSell)
        {
            CheckEda myCheck = new CheckEda();
            // List<Food>
            // double Itog
            // int id
            myCheck.id = checkCounter;
            checkCounter++;

            myCheck.food.Add(itemToSell, 1);

            myCheck.Itog = itemToSell.price;

            return myCheck;
        }
        public CheckEda SellItem(List<Dop> itemsToSell)
        {
            CheckEda myCheck = new CheckEda();
            myCheck.id = checkCounter;
            checkCounter++;
            myCheck.Itog = 0;

            foreach(Dop myfood in itemsToSell)
            {
                myCheck.Itog = myCheck.Itog + myfood.price;
                myCheck.food.Add(myfood, 1);
            }
            return myCheck;

        }
        public CheckEda SellItem(Dop itemToSell, int quantity)
        {
            CheckEda myCheck = new CheckEda();
            
            myCheck.id = checkCounter;
            checkCounter++;

            myCheck.food.Add(itemToSell, quantity);

            myCheck.Itog = itemToSell.price * quantity;
            return myCheck;
        }
        public CheckEda SellItem(Dictionary<Dop, int> itemsToSell)
        // добавление нового
        {
            CheckEda myCheck = new CheckEda();
            myCheck.id = checkCounter;
            checkCounter++;
            myCheck.Itog = 0;

            foreach (KeyValuePair<Dop,int> myfood in itemsToSell)
            {
                myCheck.Itog = myCheck.Itog + myfood.Key.price * myfood.Value;
                myCheck.food.Add(myfood.Key, myfood.Value);
            }
            return myCheck;
        }
        public void AddNewItem(Dop itemToAdd)
        {
            myMeny.Add(itemToAdd);
        }
        public void AddNewItem(List<Dop> itemsToAdd)
        {
            myMeny.AddRange(itemsToAdd);
        }
        // удаление
        public void RemoveItem(Dop itemToRemove)
        {
            myMeny.Remove(itemToRemove);
        }
        public void RemoveItem(List<Dop> itemsToRemove)
        {
            foreach (Dop myAddon in itemsToRemove)
            {
                myMeny.Remove(myAddon);
            }
        }
        public Cafe()
        {
            myMeny = new List<Dop>();

        }
    }
}
