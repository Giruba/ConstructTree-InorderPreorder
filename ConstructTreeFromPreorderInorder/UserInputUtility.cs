using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructTreeFromPreorderInorder
{
    static class UserInputUtility
    {
        public static int[] GetArrayFromUserInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements " +
                "in the array");
            try {
                int numberOfElements = int.Parse(Console.ReadLine());
                array = new int[numberOfElements];
                Console.WriteLine("Enter the elements of the array separated " +
                    "by space, colon or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ', ';', ',');
                for (int index = 0; index < numberOfElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;
        }
    }
}
