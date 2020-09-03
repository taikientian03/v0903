using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        int vx = -20;
        int vy = -20;
        int  pointToClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left =vx;
            label1.Top =vy;

            if(label1.Left<0);
            {
               vx=(int)Math.Abs(vx);
            }
            if(label1.Top<0);
            {
                vy=(int)Math.Abs(vy);
            }
            if(label1.Right>ClientSize.Width);
            {
                vx=(int)-Math.Abs(vx);
            }
            if(label1.Right>ClientSize.Height);
            {
                vy=(int)-Math.Abs(vy);
            }
            // 2次元クラスPoint型の変数cposを宣言
　　Point mp = MousePosition;

    // mpに、マウスのフォーム座標を取り出す。
    //// MousePositionにマウス座標のスクリーン左上からのX、Yが入っている。
    //// PointToClient()を使うと、スクリーン座標を、フォーム座標に変換できる。
    mp = pointToClient(mp);

    // ラベルに座標を表示
    //// 変換したフォーム座標は、cpos.X、cpos.Yで取り出せる。
    label1.Text =""+mp.X+","mp.Y;
        }
    }
}
