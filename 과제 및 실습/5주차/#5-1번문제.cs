using System;

    namespace _201074627_김혜진
    {
        public abstract class ProtossUnit
        {

            // 종족이름
            private String clan;


            // 종족= 프로토스
            public ProtossUnit(string clan)
            {
                this.clan = clan;
            }

            public String getClan()
            {
                return clan;
            }

            // 각 항목별 추상 메소드 구현 > 이름,데미지,체력,쉴드,스킬
            public abstract String getName();
            public abstract int getDamage();
            public abstract int getStrength();
            public abstract int getShield();
            public abstract String getSkill();

        }

        // ProtossUnit을 상속 받는 DarkTemplar
        public class DarkTemplar : ProtossUnit 
        {
            private String name;
            private String skill;

            public DarkTemplar()
                : base("프로토스")
            {
                this.name = "다크템플러";
            }
            
            // 오버라이드
            override public String getName()  //이름
            {
                return name;
            }

            public override int getDamage() // 데미지
            {
                return 45;

            }

            public override int getStrength() // 체력
        {
                return 40;
            }

            public override int getShield() //쉴드
            {
                return 80;

            }

            public override string getSkill() // 스킬 > 스트링형으로 반환
            {
                this.skill = "클로킹";
                return skill; 
            }

        }


        public class Nexus
        {
            public Nexus(int Mineral)
            {
                if (Mineral >= 50)
                    Console.WriteLine("프로브 생산");
                else
                    Console.WriteLine("광물이 부족합니다.");
            }
            public Nexus(int Mineral, int Gas)
            {
                if (Mineral >= 300 && Gas >= 300)
                    Console.WriteLine("모선 생산");
                else
                    Console.WriteLine("광물 혹은 가스가 부족합니다.");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                ProtossUnit DT = new DarkTemplar();

                int Damage = DT.getDamage();
                int Strength = DT.getStrength();
                int Shield = DT.getShield();

                Console.WriteLine("종족: " + DT.getClan());
                Console.WriteLine("이름: " + DT.getName());
                Console.WriteLine("쉴드: " + Shield);
                Console.WriteLine("체력: " + Strength);
                Console.WriteLine("데미지: " + Damage.ToString());
                Console.WriteLine("스킬: " + DT.getSkill());

                Console.WriteLine();

                Nexus N1 = new Nexus(40);
                Nexus M1 = new Nexus(30, 30);

                Console.WriteLine();

                Nexus N2 = new Nexus(50);
                Nexus M2 = new Nexus(300, 300);

                Console.WriteLine();
            }
        }
    }