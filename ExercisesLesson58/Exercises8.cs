///<summary>
///<author>Branium Academy</author>
///<see cref="Trang chu" href="https://braniumacademy.net"/>
///<version>2022.04.01</version>
///</summary>

using System;

namespace ExercisesLesson58
{
    class Exercises8
    {
        struct Increment
        {
            public int length; // độ dài dãy tăng
            public int startPos; // vị trí bắt đầu của dãy trong mảng gốc
            public int[] elements; // các phần tử của dãy

            public Increment(int length, int startPos, int[] elements)
            {
                this.length = length;
                this.startPos = startPos;
                this.elements = elements;
            }
        }

        static void Main()
        {

        }
    }
}
