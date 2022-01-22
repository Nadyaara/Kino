using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Model
{
    public class KorzinaVM
    {
        private int KorzinaCounter;
        public Korzina myKorzina;
       
        public KorzinaVM(User myUser)
        {
            myKorzina = new Korzina(KorzinaCounter, myUser, new Dictionary<Dop, int>(), 0);
            KorzinaCounter++;
        }


       public void DobavEssen(Dop DobavEssen)
       {
            int param = 0;
            
            myKorzina.Essen.TryGetValue(DobavEssen, out param);
            if(param >= 1)
            {
                myKorzina.Essen.Remove(DobavEssen);
                myKorzina.Essen.Add(DobavEssen, param++);
            }
            else
            {
                myKorzina.Essen.Add(DobavEssen, 1);
            }
       }

        public void CleanEssen(Dop CleanEssen)
        {
            myKorzina.Essen.Remove(CleanEssen);
        }

        public void CleanOneEssen(Dop CleanOneEssen)
        {
            int param = 0;

            try
            {

                myKorzina.Essen.TryGetValue(CleanOneEssen, out param);
                if (param > 1)
                {
                    myKorzina.Essen.Remove(CleanOneEssen);
                    myKorzina.Essen.Add(CleanOneEssen, param--);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка. Не сущетсвует");
            }
        }
    }
}
