using System;
using System.Globalization;
public class Program
{
   
    public static void BinarySearch()
    {
        
    } 
    public static void BubbleSort()
    {
        bool sorted = false;
        int A =0;
        int swap = 0;
       string[] NameLis = {"Harry","Reuben","Jimmy","Kodi","Tom","Matthew","Finn","Aiaa"};
       while (sorted == false)
       {
        for (int i = 0; i < NameLis.Length; i++)
        {
        swap = 0;
                if (Convert.ToUInt16(NameLis[A].Substring(0)) > Convert.ToUInt16(NameLis[A+1].Substring(0)))
            {
                 string saver2 = NameLis[A+1];
                 NameLis[A] =   NameLis[A+1];
                 NameLis[A+1] = saver2;
            }
            else
            {
            swap = swap +1;
            }
        }
            if (A ==7)
            {
                A = 0;
            }
            if(swap == 7)
            {
                sorted = true;
                break;
            }
         A++;
         Console.WriteLine("Pass "+ A);
       }
    } 
   public static bool LinearSearch(string name)
    {
        bool status = false;
        string[] NameList = {"Harry","Reuben","Jimmy","Kodi","Tom","Matthew","Finn","Aiaa"};
        for (int i = 0; i < NameList.Length; i++)
        {
          if (NameList[i]== name)
            {
                Console.WriteLine("Found "+ NameList[i]+ " At position "+i+" of list");
                status = true;
            }
        }
        return status;
    } 
	public static void Main()
    {
        string[] NameList = {"Harry","Reuben","Jimmy","Kodi","Tom","Matthew","Finn","Aiaa"};
       Console.WriteLine("who would you like to search for?");
       string name = Console.ReadLine();
        bool status = LinearSearch(name); 
        Console.WriteLine(status);
        BubbleSort();
    }
}