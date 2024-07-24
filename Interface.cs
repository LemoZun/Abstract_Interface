namespace Program
{
    /***************************************************************************
         * 인터페이스 (Interface)
         * 
         * 인터페이스는 맴버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
         * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함 ~able
         ***************************************************************************/
    // <인터페이스 정의>
    // 일반적으로 인터페이스의 이름은 I로 시작함
    // 인터페이스의 함수는 직접 구현하지 않고 정의만 진행
    internal class Interface
    {
        public interface IEnterable
        {
            public void Enter(); // 선언만 해줌
        }
        public interface IOpenable
        {
            public void Open();
        }

        public class Chest : IOpenable // lock을 상속해도 됨
        {

            public void Open()
            {
                Console.WriteLine("상자를 엽니다.");
            }
        }
        public class Dungeon : IEnterable // entrance 상속해도 됨
        {

            public void Enter()
            {
                Console.WriteLine("던전에 들어갑니다.");
            }
        }

        public class Door : IEnterable, IOpenable // entrance와 lock 한번에 상속 불가(다중상속 불가)
        {

            public void Enter()
            {
                Console.WriteLine("문으로 들어갑니다.");
            }
            public void Open()
            {
                Console.WriteLine("문을 엽니다.");
            }
        }

        public class Car : IEnterable, IOpenable //새로운 컨텐츠를 추가할 시 바로 구현이 가능
        {
            private bool isOpened;
            public void Enter()
            {
                if (isOpened) Console.WriteLine("차에 탑승합니다.");
                else Console.WriteLine("잠금 장치부터 먼저 해제해 주세요.");

            }
            public void Open()
            {
                Console.WriteLine("차의 잠금을 엽니다.");
                isOpened = true;

            }

        }


        public class Enterance
        {

            public void Enter() { }
        }

        public class Lock
        {

            public void Open() { }
        }


        public class Player
        {

            public void Enter(IEnterable enterable)
            {
                enterable.Enter();
            }
            public void Open(IOpenable openable)
            {
                openable.Open();
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            Dungeon dungeon = new Dungeon();
            Chest chest = new Chest();
            Door door = new Door();
            Car car = new Car();

            player.Enter(dungeon);
            player.Enter(door);

            player.Open(chest);
            player.Open(door);
            player.Enter(car);
            player.Open(car);
            player.Enter(car);


        }







    }

}

