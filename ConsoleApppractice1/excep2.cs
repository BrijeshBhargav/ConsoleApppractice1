using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApppractice1
{
    internal class excep2
    {
        public static void e1()
        {
            TryAgain:
            try
            {
                Console.WriteLine("enter x val:");
                int x= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter y val:");
                int y= Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("div is :" + z);
                string str = "null";
                Console.WriteLine(str.Length);
                int[] x2 = { 12, 3, 4, 5 };
                for (int i = 0; i < x2.Length; i++)
                {
                    Console.WriteLine(x2[3]);
                }

              
             StreamReader strmrdr = new StreamReader("C:\\Users\\HP\\OneDrive\\Desktop\text1.txt");
             Console.WriteLine(strmrdr.ReadToEnd());
             strmrdr.Close();
               

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("cant find lnth of null :"+ex.Message);
                goto TryAgain;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("cant divide any thing by zero:"+ex.Message);
                goto TryAgain;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("pls enter only int val"+ex.Message);
                goto TryAgain;
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine ("there is no such file :"+ex.Message );
                goto TryAgain;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("someth went wrong:" +ex.Message);
                goto TryAgain;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine (ex.Message );
              
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index is out of range:"+ex.Message);
                goto TryAgain;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine ("plz enter in int range :"+ex.Message);
                goto TryAgain;
            }
            

        }
    }
}
