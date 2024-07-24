using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming
{
    internal class Abstraction
    {
        /*
         * 추상화
         * 클래스를 정의할 당시 구체화 시킬 수 없는 기능을 추상적 표현으로 정의
         * 자식에서 반드시 정의하도록 강요하는 역할
         * abstract 메소드가 하나라도 있는 클래스라면 클래스 앞에도 abstract를 붙여줘야함 
         * virtual - 허락 / abstract - 강제
         */
        public abstract class Item
        {
            public abstract void Use();
        }

        public class Potion : Item
        {
            public override void Use() //안만들면 에러
            {
                Console.WriteLine("체력을 회복합니다."); 
            }
        }


    }
}
