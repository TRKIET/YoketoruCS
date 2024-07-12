
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;


namespace YoketoruCS

{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int EnemyMax => 4;
        static int ItemMax => 4;

        static int PlayerIndex => 0;
        static int EnemyIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => EnemyIndex + EnemyMax;
        static int LabelMax => ItemIndex + EnemyMax;

        Label[] labels = new Label[LabelMax];

        static Random random = new Random();

        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];

        static int SpeedMax => 10;

        int score ;
        int timer ;


        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }

        //<summary>
        //次に切り替えたい状態
        //</summary>
        State nextState = State.Title;

        //<summry>
        //現在の状態
        //</summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Visible = false;
                Controls.Add(labels[i]);

                tempPlayer.Visible = false;
                tempEnemy.Visible = false;
                tempItem.Visible = false;

                //Text,Font,ForeColorを種類ごとに設定したい



                //アイテムの時
                //iが???の時
                if (i > ItemIndex)
                {
                    labels[i].Font = tempItem.Font;
                    labels[i].ForeColor = Color.Black;
                    labels[i].Text = tempItem.Text;
                }
                //敵の時
                //iが???の時
                else if (i >= EnemyIndex)
                {
                    labels[i].Font = tempItem.Font;
                    labels[i].ForeColor = Color.Black;
                    labels[i].Text = tempEnemy.Text;
                }
                else
                //プレイヤーの時
                //iが???の時
                {
                    labels[i].Font = tempItem.Font;
                    labels[i].ForeColor = Color.Black;
                    labels[i].Text = tempPlayer.Text;
                }
                if (i >= EnemyIndex)
                {
                    labels[i].Left = labels[i - 1].Left + labels[i - 1].Width;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();

        }

        void InitState()
        {　//番人
            if (nextState == State.None)
            {
                return;
            }
            currentState = nextState;
            nextState = State.None;

            //初期化処理
            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;

                    labelGameover.Visible = false;
                    buttonToTitle.Visible = false;
                    labelClear.Visible = false;
                    break;


                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    for (int i = 0; i < LabelMax; i++)
                    {
                        labels[i].Visible = true;
                        vx[i] = random.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = random.Next(-SpeedMax, SpeedMax + 1);
                        labels[i].Left = random.Next(0, ClientSize.Width - labels[i].Width);
                        labels[i].Top = random.Next(0, ClientSize.Height - labels[i].Height);
                    }
                    score = 0;
                    timer = 200;
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;

            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }

            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }

            //プレイヤー移動
            var fpos = PointToClient(MousePosition);
            labels[PlayerIndex].Left = fpos.X - labels[PlayerIndex].Width / 2;
            labels[PlayerIndex].Top = fpos.Y - labels[PlayerIndex].Height / 2;

            //キャラクターの更新
            UpdateChrs();

            //時間の更新
            timer--;
            labelTimer.Text = $"{timer}";

            if(timer<=0)
            {
                nextState = State.Gameover;
            }            
            

        }

        void UpdateChrs()
        {
            var fpos =PointToClient(MousePosition);


            //敵とアイテムの移動
            for (int i = EnemyIndex; i < LabelMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > (ClientSize.Width - labels[i].Width))
                {
                    vx[i] = -Math.Abs(vx[i]);
                }

                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Top > (ClientSize.Height - labels[i].Height))
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //fposがラベルと重なっているか判定
                if ((fpos.X > labels[i].Left)
                    && (fpos.X < labels[i].Right)
                    && (fpos.Y > labels[i].Top)
                    && (fpos.Y < labels[i].Bottom))
                {
                    //敵の時、ゲームオーバー
                    if (i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //アイテム
                        score += 100;
                        labelScore.Text = $"{score}";
                        labels[i].Enabled = false;
                        
                    }

                    if (ItemIndex <= 4) 
                    {
                        nextState = State.Clear;
                    }

          
                }

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonToTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}