
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
                Controls.Add(labels[i]);

                //Text,Font,ForeColorを種類ごとに設定したい

                //プレイヤーの時
                //iがの時

                //敵の時
                //iがの時

                //アイテムの時
                //iがの時


                if (i == PlayerIndex)
                {
                    labels[i].Text = labelPlayer.Text;
                    labels[i].Font = labelPlayer.Font;
                    labels[i].ForeColor = labelPlayer.ForeColor;
                }
                if(i == EnemyIndex) 
                {
                    labels[i].Text= labelEnemy.Text;
                    labels[i].Font = labelEnemy.Font;
                    labels[i].ForeColor= labelEnemy.ForeColor;
                }
                if (i == ItemIndex) 
                {
                    labels[i].Text=labelItem.Text;
                    labels[i].Font=labelItem.Font;
                    labels[i].ForeColor=labelItem.ForeColor;

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