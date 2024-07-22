namespace OOP_Repot
{
    class Character
    {
        public int level;
        public int hp;
        public float walkSpeed;
        public int attackPower;        

        public void MoveForward()
        {
            Console.WriteLine("캐릭터가 앞으로 갑니다.");
            walkSpeed = 5;
        }

        public void MoveBack()
        {
            Console.WriteLine("캐릭터가 뒤로 갑니다.");
            walkSpeed = 5;
        }

        public void MoveLeft()
        {
            Console.WriteLine("캐릭터가 왼쪽으로 갑니다.");
            walkSpeed = 5;
        }

        public void MoveRight()
        {
            Console.WriteLine("캐릭터가 오른쪽으로 갑니다.");
            walkSpeed = 5;
        }

        public void Attack()
        {
            Console.WriteLine("캐릭터가 공격합니다.");
            attackPower = 20;
        }

        public void DamagedAttack()
        {
            Console.WriteLine("캐릭터가 몬스터의 공격력으로 데미지를 입습니다.");
            
            hp -= attackPower;
        }
    }
    internal class OOP_Repot
    {       
       
        static void Main(string[] args)
        {
            Character player = new Character();            
            
            Console.WriteLine();
        }
    }
}
