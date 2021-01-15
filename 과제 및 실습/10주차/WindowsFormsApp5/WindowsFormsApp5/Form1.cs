using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 5-10초 간격으로 벽돌깬 곳에서 아이템이 위에서 아래로 떨어진다. 
 * 아이템은 총을 쏠 수 있는 기능으로 racket이 총으로 바뀐다. 
 * 바뀐 후 5초 후 원래의 racket으로 돌아온다.
 * 총으로 바뀌면 스페이스바를 누르면 총알이 발사된다.
 * 발사된 총알이 블럭을 맞추면 블럭이 사라진다.
 */
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Graphics g;
        int nBlocks = 20;   // 최초 20개
        int level = 3;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];  // 블록 rectagle 배열
        bool[] bVisible = new bool[100];
        Rectangle ball, item, shoot;

        bool itemStrarted = false;
        bool shootStarted = false;

        Brush racketColor = new SolidBrush(Color.DarkOrange); // 라켓 색
        Brush blockColor = new SolidBrush(Color.DarkOliveGreen); // 블럭 색
        Brush ballColor = new SolidBrush(Color.Gold); // 공 색
        Brush shootColor = new SolidBrush(Color.Blue); // 총알 색
        Brush itemColor = new SolidBrush(Color.Blue); // 아이템 색
        Pen pen = new Pen(Color.Black); // shoot테두리

        int racketY = 480;  // racket의 위치
        int formW = 300;  // Form의 폭
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;    // 블록 위치
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        int itemW = 15;  // 아이템 크기
        int itemH = 15;

  
        int shootW = 10;    // 총알 크기
        int shootH = 10;
        int count = 0;
        int count2 = 0;

        Timer t;
        Timer myTimer = new Timer();    // main Timer
        Timer shootTimer = new Timer();   // shoot
        Timer itemTimer = new Timer();   // Item
        
        private double slope;       // 공의 기울기 0.5~2 랜덤     
        private double vDir = 1;         // 수직방향 1=아래, -1=위
        private double shootspeed = 20; // 총알 속도

        Random r = new Random();
        Random r2 = new Random(); // 아이템 위치 
        Random random_time = new Random(); // 아이템 시간

        private int clearedBlocks = 0;
        private int MaxBlocks = 100;

        System.Media.SoundPlayer myPlayer;
        System.Media.SoundPlayer[] blockSound = new System.Media.SoundPlayer[4];
        private int initialBallPosition;    // 최초 볼의 위치(y 좌표)

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(300, 500);
            this.Text = "Block Breaker v1.0";

            initbVisible();
            initRacket();
            initBlocks();
            StartBall();
            StartItem(); 

            initSound();

            myTimer.Tick += myTimer_Tick;

            myTimer.Interval = 50;  // milliseconds
            myTimer.Start();
            
            itemTimer.Tick += itemTimer_Tick;
            itemTimer.Interval = random_time.Next(5,15)*1000; //5~15초 사이의 랜덤한 값 마다 itemTimer 호출
            itemTimer.Start();  
        }

        private void initSound()
        {
            myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = "Windows Battery Critical.wav";

            for (int i = 0; i < 4; i++)
            {
                blockSound[i] = new System.Media.SoundPlayer();
            }
            blockSound[0].SoundLocation = "Windows Battery Critical.wav";
            blockSound[1].SoundLocation = "Windows Battery Low.wav";
            blockSound[2].SoundLocation = "Windows Notify.wav";
            blockSound[3].SoundLocation = "Windows User Account Control.wav";
        }

        private void initbVisible()
        {
            for (int i = 0; i < nBlocks; i++)
                bVisible[i] = true;
        }

        private void initRacket()
        {
            racket.X = formW / 2 - racketW / 2;  // 중앙
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        private void initBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;    // 중앙
            ball.Y = blockY + nBlocks / 10 * blockH;
            initialBallPosition = ball.Y;
            ball.Width = ballW;
            ball.Height = ballH;
        }

        private void drawBall()
        {
            g.FillRectangle(ballColor, ball);
            g.DrawRectangle(pen, ball);
        }

        private void drawRacket()
        {
            if (count == 1)
            {
                count2 += 50;
            }
            if (count == 1)
            {
                g.FillRectangle(new SolidBrush(Color.Blue), racket);

            }
            else
                g.FillRectangle(racketColor, racket);

            if ((count == 1) && (count2 != 0) && (count2 % 5000 == 0))
            {
                Console.WriteLine(count2);
                g.FillRectangle(racketColor, racket);
                count = 0;

            }
        }

        private void initBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
                blocks[i] = new Rectangle(i % 10 * blockW, blockY + blockH * (i / 10),
                     blockW - 1, blockH - 1);
        }

        private void drawBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
                if (bVisible[i])
                    g.FillRectangle(blockColor, blocks[i]);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
                if (racket.X < 0)
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
                if (racket.X > formW - racketW)
                    racket.X = formW - racketW;
            }
            else if (e.KeyCode == Keys.Up)
            {
                racket.Y -= 10;
                if (racket.Y < initialBallPosition)     // 최초 볼 높이보다 더 높아지지는 않게
                    racket.Y = initialBallPosition;
            }
            else if (e.KeyCode == Keys.Down)
            {
                racket.Y += 10;
                if (racket.Y > ClientSize.Height - 20)
                    racket.Y = ClientSize.Height - 20;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                myTimer.Stop();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                myTimer.Start();
            }

            else if (e.KeyCode == Keys.Space && count == 1)
            {
                if (!shootStarted)
                {
                    shootStarted = true;
                    Startshoot();
                    shootTimer.Tick += shootTimer_Tick;
                    shootTimer.Interval = 100;  // milliseconds
                    shootTimer.Start();
                }                    
            }
            Invalidate();
        }

        private void initItem() ////////////////////////////////////////////////////
        {
            item = new Rectangle();
            item.X = r2.Next(10, 290);
            item.Y = 10;
            item.Width = itemW;
            item.Height = itemH;
        }

        private void initshoot() /////////////////////////////////////////
        {
            shoot = new Rectangle();
            shoot.X = (racket.X + 18); // 가운데에서 나감
            shoot.Y = racket.Y;
            shoot.Width = shootW;
            shoot.Height = shootH;
        }

        private void drawItem() /////////////////////////////////////
        {
            if (itemStrarted) // itemTimer_Tick이 실행되면 
            {
                g.FillRectangle(itemColor, item); // 아이템 생성
            }
        }

        private void drawshoot() ////////////////////////////////
        {
            if (shootStarted)
                g.FillRectangle(shootColor, shoot);
        }

        protected override void OnPaint(PaintEventArgs e) ///////////////////
        {
            g = e.Graphics; 
            drawRacket();
            drawBlocks();
            drawBall();
            drawItem(); 

            if (count == 1) //아이템과 충돌하였으면
            {
                drawshoot(); //총알을 그려준다.
            }
        }

        private void StartItem()
        {
            initItem();
        }

        private void Startshoot()
        {
            initshoot();
        }

        private void StartBall()
        {
            initBall();
            slope = r.Next(5, 20) / 10.0;
            if (r.Next(2) % 2 == 1)
                slope = -slope;
        }

        void myTimer_Tick(object sender, EventArgs e)
        {
            double dX;
            //double unit = ballW;

            dX = (double)level / slope; // 레벨 바뀔때마다 속도 빨라지도록
            ball.X += (int)dX;  // 속도 조절을 위해 slope로 나누어 줌, +- 구분할 필요 없음
            ball.Y += (int)(vDir * slope * dX);

            // ball이 좌우 벽에 충돌하였는지 체크
            if (ball.X < 0 || ball.X > formW - ballW)
            {
                myPlayer.Play();
                slope = -slope;
            }
            // ball이 천장이나 라켓에 맞았는지 체크
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                myPlayer.Play();
                vDir = -vDir;
            }

            Invalidate();

            // ball이 화면 아래보다 더 내려갔다면, 라켓으로 받아내지 못한 것이므로 죽은 것
            if (ball.Y > ClientSize.Height)
            {
                StartBall();
                return;
            }

            // 블록의 맨 아래 위치보다 볼이 더 아래에 있다면 블록과의 intersect를 비교하지 않는다
            if (ball.Y > blockY + blockH * nBlocks / 10)
                return;

            Random sRnd = new Random();
            for (int i = 0; i < nBlocks; i++)
            {
                if (bVisible[i] && ball.IntersectsWith(blocks[i]))
                {
                    bVisible[i] = false;
                    vDir = -vDir;

                    int index = sRnd.Next(0, 3);
                    blockSound[index].Play();
                    if (++clearedBlocks >= nBlocks)
                    {
                        myTimer.Stop();

                        if (nBlocks == MaxBlocks)
                        {
                            MessageBox.Show("Final Stage Cleared!", "Mission Completed!!", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            string str = string.Format("Level {0} Completed! Play More?", level);
                            DialogResult result = MessageBox.Show(str, "Level Clear!", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                newLevelStart();
                            else
                                Close();
                        }
                    }
                }
            }
        }
        
        
        void itemTimer_Tick(object sender, EventArgs e) ///////////////////
        {
            if (!itemStrarted)
            {
                t = new Timer();
                t.Tick += Item;
                t.Interval = 60;  // milliseconds
                t.Start();
                itemStrarted = true;
            }       
        }

        //아이템 뿌려주기 50ms 간격
        void Item(object sender, EventArgs e)
        {
            item.Y += 10;
            if (racket.IntersectsWith(item))
            {
                count = 1;
                StartItem();
                t.Stop();
                itemStrarted = false;
                return;
            }
            if (item.Y > ClientSize.Height) //아이템을 못받았을 경우
            { 
                StartItem(); //다시 아이템 시작
                t.Stop();
                itemStrarted = false;
                return;
            }         
        }

        void shootTimer_Tick(object sender, EventArgs e)
        {
            shoot.Y -= (int)shootspeed;
            Random sRnd2 = new Random();
            
            for (int i = 0; i < nBlocks; i++)
            {
                if (bVisible[i] && shoot.IntersectsWith(blocks[i]))
                {
                    bVisible[i] = false;                   
                    int index = sRnd2.Next(0, 3);

                    if (++clearedBlocks >= nBlocks)
                    {
                        if (nBlocks == MaxBlocks)
                        {
                            MessageBox.Show("Final Stage Cleared!", "Mission Completed!!", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            string str = string.Format("Level {0} Completed! Play More?", nBlocks / 20);
                            DialogResult result = MessageBox.Show(str, "Level Clear!", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                newLevelStart();
                            else
                                Close();
                        }
                    }
                    shootStarted = false;
                    shootTimer.Stop();
                }
            }
        }
        /// ////////////
        private void newLevelStart()
        {
            if (nBlocks > MaxBlocks)
                return; // nBlocks = MaxBlocks;

            if (nBlocks > MaxBlocks)
                return; // nBlocks = MaxBlocks;

            nBlocks += 20;  // 20개 씩 증가

            initbVisible();
            initRacket();
            initBall();
            initBlocks();

            clearedBlocks = 0;

            StartBall();
            myTimer.Start();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}