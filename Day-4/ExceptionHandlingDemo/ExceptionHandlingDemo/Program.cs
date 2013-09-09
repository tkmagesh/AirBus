using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            try
            {
                throw new MyOwnException();
                var list = new ArrayList();
                list.Add(100);
                list.Add(200);
                //list.Add("some string");
                list.Add(400);
                foreach (var item in list)
                {
                    var number = (int) item;
                    result += number;
                }

            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Some data in the list is not convertible to int");
            }
            catch (MyOwnException)
            {
                Console.WriteLine("Your own exception is thrown...");
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Console.WriteLine("total = {0}", result);
            }
            
            Console.ReadLine();
        }
    }

    public class MyOwnException : Exception
    {
        
    }
}
