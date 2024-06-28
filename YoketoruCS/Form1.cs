
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;


namespace YoketoruCS

{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear,
        }

        //<summary>
        //���ɐ؂�ւ��������
        //</summary>
        State nextState = State.Title;

        //<summry>
        //���݂̏��
        //</summary>
        State currentState = State.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitState();
            UpdateState();
        }

        void InitState()
        {�@//�Ԑl
            if (nextState == State.None)
            {
                return;
            }
            currentState = nextState;
            nextState = State.None;

            //����������
            switch (currentState)
            {
                case State.Title:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;

                    labelGameover.Visible= false;
                    buttonToTitle.Visible= false; 
                    break;


                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonToTitle.Visible = true;
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
    }
}