using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _20174627_김혜진
{

    // game.cs
    abstract class Game  //추상 클래스
    {
        protected int userWin, computerWin, drawnMatch; // 승,무,패
        public Game() // 생성자
        {
            userWin = computerWin = drawnMatch = 0;
        }
        ~Game() // 소멸자
        {
            recordPrint(); // 승,무,패 출력
        }
        //추상 메소드, 파생 클래스에서 꼭 재정의를 해줘야 한다.
        public abstract void result(); // 결과 처리 메소드
        public void recordPrint() // 결과 출력 메소드 (승,무,패)
        {
            Console.WriteLine(userWin + "승 " + computerWin + "패 " + drawnMatch + "무승부입니다.");
        }
    }

    // Srp.cs (가위바위보 클래스) - Game 클래스 생속
    class Srp : Game // Game 클래스로부터 상속받는 Srp 클래스
    {
        private string computer, user;
        private int win, lose, draw;
        public Srp() { }
        public virtual string GetValue(int a)
        {
            if (a == 1) return "가위";
            else if (a == 2) return "바위";
            else if (a == 3) return "보";
            else return "다시시작";
        }
        public override void result()
        {
            throw new NotImplementedException();
        }
        public string outcome(int result) // 가위바위보 결과
        {
            string tmp = null;
            switch (result)
            {
                case 0:
                    tmp = "무승부";
                    break;
                case 1:
                    tmp = "이겼습니다.";
                    break;
                case 2:
                    tmp = "졌습니다.";
                    break;
            }
            return tmp;
        }
 

        public virtual void play() // 게임 시작
        {
            int tmp, result = 0;
            // 컴퓨터가 뭘 낼지 결정
            Random r = new Random();
            int a = r.Next(1, 3);
            computer = GetValue(a);
            
            do
            {
                Console.WriteLine("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)]");
                tmp = Convert.ToInt32(Console.ReadLine());
                user = GetValue(tmp);
                Console.WriteLine("컴퓨터는 " + computer + "를 냈습니다.");
                
                //승,패,무 계산식
                if (a == tmp)
                {
                    draw += 1;
                    result = 0;
                }
                else if (a == 1 && tmp == 2)
                {
                    win += 1;
                    result = 1;
                }
                else if (a == 1 && tmp == 3)
                {
                    lose += 1;
                    result = 2;
                }
                else if (a == 2 && tmp == 1)
                {
                    lose += 1;
                    result = 2;
                }
                else if (a == 2 && tmp == 3)
                {
                    result = 1;
                    win += 1;
                }
                else if (a == 3 && tmp == 1)
                {
                    result = 1;
                    win += 1;
                }
                else if (a == 3 && tmp == 2)
                {
                    result = 2;
                    lose += 1;
                }
                Console.WriteLine(outcome(result));
            } 

            // 게임 종료 시 결과 출력
            while (tmp != 0);
            Console.WriteLine(win + "승 " + lose + "패 " + draw + "무승부입니다.");
        }
    }

    //묵찌빠 클래스 - 가위바위보 클래스 상속
    class Mjb : Srp
    {
        protected int computer, user;
        int replace; // 공격자 교체
       
        //결과값 출력 재정의.
        public override void result()
        {
            if (replace == 1)
            {
                Console.WriteLine("이겼습니다.");
                userWin += 1;
            }
            else if (replace == 0)
            {
                Console.WriteLine("졌습니다.");
                computerWin += 1;
            }
        }

        //공격자 교체
        public void replacing()
        {
            if (this.user == 1)
            {
                if (this.computer == 2) replace = 0;
                if (this.computer == 3) replace = 1;
            }
            else if (this.user == 2)
            {
                if (this.computer == 3) replace = 0;
                if (this.computer == 1) replace = 1;
            }
            else if (this.user == 3)
            {
                if (this.computer == 1) replace = 0;
                if (this.computer == 2) replace = 1;

            }
        }

        public void comDisplay()
        {
            if (this.computer == 1) Console.WriteLine("컴퓨터는 가위를 냈습니다.");
            else if (this.computer == 2) Console.WriteLine("컴퓨터는 바위를 냈습니다.");
            else if (this.computer == 3) Console.WriteLine("컴퓨터는 보를 냈습니다.");
        }

        //게임 플레이!
        public void play()
        {
            while (true)
            {
                Console.Write("입력하세요 [가위<1>, 바위<2>, 보<3>, 종료<0>] : ");
                this.user = Int32.Parse(Console.ReadLine());
                //게임 종료시 게임결과 출력
                if (this.user == 0)
                {
                    break;
                }
                Random r = new Random();
                this.computer = r.Next(1, 3);

                this.comDisplay();
                if (this.computer == this.user)
                {
                    Console.WriteLine("다시 냅니다.");
                    continue;
                }

                Console.WriteLine("묵찌빠 시작\n");
                while (true)
                {
                    this.replacing();                //공수 교대
                    if (this.computer == this.user) //승부가 결정되었을 때
                    {
                        this.result();              //결과 출력 및 루프탈출
                        break;
                    }

                    if (replace == 1) Console.WriteLine("공격자는 유저입니다.");
                    else Console.WriteLine("공격자는 컴퓨터입니다.");

                    Console.Write("입력하세요 [가위<1>, 바위<2>, 보<3>, 종료<0>] : ");
                    this.user = Int32.Parse(Console.ReadLine());
                    this.computer = r.Next(1, 4);

                    this.comDisplay();
                }
            }
        }
    }


    class game
        {
            static void Main(string[] args)
            {
                Console.Write("선택하세요 [가위바위보 게임(1), 묵찌빠 게임(2)] : ");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    new Srp().play();
                }
                else if (i == 2)
                {
                    Console.WriteLine("묵찌빠 시작");
                    new Mjb().play();
                }
                else Console.WriteLine("잘못 입력");
            
            
            }
        }
    }
