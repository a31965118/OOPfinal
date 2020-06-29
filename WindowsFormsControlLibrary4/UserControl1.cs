using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary4
{
    public partial class UserControl1: UserControl
    {
        string[,] dataArray;//食物陣列
        string txt_FilePath = "";//用來記錄當前開啟檔案的路徑的  
        BST.BinarySearchTree bst;
        //string sum;//傳送輸入的卡路里數值
        string test = "吃五色蔬菜，有效預防癌症!並且每天要攝入500-1000克的蔬菜，大概是每天五~七份拳頭大小，以及吃完整的蔬菜，" +
            "不要把蔬菜榨成汁，重要的維生素還有其他營養素會流失掉!";

        public UserControl1()
        {
            InitializeComponent();
        }
        class Employee
        {
            public string empname { get; set; }
            public string empheight { get; set; }
            public string empweight { get; set; }
            public string empbmi { get; set; }
            public string empwater { get; set; }
            public string empeat { get; set; }
            public string empsport { get; set; }



        }
        int n;
        Employee[] emp = new Employee[100];
        private void UserControl1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            button7.Enabled = false;
            button8.Enabled = false;
            txtshow.Font = new Font(txtshow.Font.FontFamily, 11, FontStyle.Regular);
            txtshow.ReadOnly = true;
           
            n = 0;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("請先輸入身高與體重的數值(cm/kg)");
            }
            else
            {
            string h, w;
            h = textBox1.Text;
            w = textBox2.Text;
            double h1 = double.Parse(h);
            double w1 = double.Parse(w);
            int drink = (Int32)w1 * 40;
            double bmi = w1 / ((h1 / 100) * (h1 / 100));
                double BMI = Math.Round(bmi, 2, MidpointRounding.AwayFromZero);
                label4.Text = BMI.ToString();
                label6.Text = drink.ToString();
            }
            
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            string h, w;
            h = textBox1.Text;
            w = textBox2.Text;
            double h1 = double.Parse(h);
            double w1 = double.Parse(w);
            double bmi = w1 / ((h1 / 100) * (h1 / 100));
            double BMI = Math.Round(bmi, 2, MidpointRounding.AwayFromZero);
            if (BMI < 19)
            {
                label8.Text = "過輕";
            }
            if(BMI>=19 && BMI < 24)
            {
                label8.Text = "正常範圍";
            }
            if(BMI>=24 && BMI < 27)
            {
                label8.Text = "過重";
            }
            if (BMI >= 27)
            {
                label8.Text = "太重了!!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d1 = label6.Text;
            string d2 = textBox5.Text;
            int dd1 = int.Parse(d1);
            int dd2 = int.Parse(d2);
            int d3 = dd1 - dd2;
            if (d3 <= 0)
            {
                label10.Text = "讚喔! 已到達今天的喝水量哩";
            }
            else 
            label10.Text = d3.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
           
        }

        private void label24_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
            
        }

        private void label26_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {  
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {  
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string c=textBox3.Text;
            int cc = int.Parse(c);
            int cth= int.Parse(label12.Text);
            cth=cth+cc;
            label12.Text=Convert.ToString(cth) ;


            //textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string B3 = Convert.ToString(textBox2.Text);
            label25.Text = B3;
            string B2 = Convert.ToString(textBox1.Text);
            label24.Text = B2;
            string B1 = Convert.ToString(textBox6.Text);
            label23.Text = B1;
            int b = Convert.ToInt32(label12.Text);
            label27.Text = b.ToString();
           
            
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            txtshow.Text = "姓名\t身高\t體重\tBMI\t今日喝水量\t今日卡路里\t今日運動量\t" + Environment.NewLine;
                txtshow.Text += "==========================================" + Environment.NewLine;
               
            
        }
        private void button5_Click(object sender, EventArgs e)//鍵入按鈕
        {
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(label27.Text);
            int c = b - a;
            int d = int.Parse(label26.Text);
            int eee = d + a;
            label27.Text = c.ToString();

            label26.Text = eee.ToString();

            emp[n] = new Employee();
            emp[n].empname = label23.Text;
            emp[n].empheight = label24.Text;
            emp[n].empweight = label25.Text;
            emp[n].empbmi = label4.Text;
            emp[n].empwater = label6.Text;
            emp[n].empeat = textBox3.Text;
            emp[n].empsport = label26.Text;

            n++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
               

            
            for (int i = 0; i < n; i++)
            {
                txtshow.Text +=
                    emp[i].empname + "\t" + emp[i].empheight + "\t" + emp[i].empweight + "\t" + emp[i].empbmi + "\t" + emp[i].empwater + "\t" + "\t"  + emp[i].empeat + "\t" + "\t" + emp[i].empsport + "\t" + Environment.NewLine;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sd.FileName);
                sw.Write(txtshow.Text);
                sw.Close();
            }
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();//一個開啟檔案的對話方塊  
            openFileDialog1.Filter = "文字檔案(*.txt)|*.txt";//設定允許開啟的副檔名  
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//判斷是否選擇了檔案    
            {
                txt_FilePath = openFileDialog1.FileName;//開啟檔案的路徑
                txtshow.Text = "";//清空textBox1
               
                StreamReader streamReader = new StreamReader(txt_FilePath, Encoding.UTF8);//記錄使用者選擇的檔案路徑
                while (!streamReader.EndOfStream)
                {//如果這個還沒有讀到檔案尾
                    string line = streamReader.ReadLine();//就一行一行地讀
                    txtshow.Text += line + "\r\n";
                }
                streamReader.Close();//一定要關閉這個流，不然會和下面儲存檔案的流衝突
            }
            else
            {
                MessageBox.Show("請開啟txt檔案");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//載入資料
        {
            bst = new BST.BinarySearchTree();//創一個'空的'新樹狀結構

            //讀入dataArray二維陣列中
            //[i, 0] 代表編號，[i, 1] 代表食物名，[i, 2] 代表單位，[i, 3] 代表大卡

            OpenFileDialog of1 = new OpenFileDialog();
            if (of1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(of1.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Default);//讀取文字內容
                string data = sr.ReadToEnd(); 
                data = data.Replace("\"", ""); //去除中間有""的部分
                string[] dataLines = data.Split('\n'); //資料用"\n"分割成字串陣列，一行是一個單字

                dataArray = new string[dataLines.Length, 5];

                for (int i = 0; i < dataLines.Length - 1; i++) //run每一行進行讀取
                {
                    dataLines[i] = dataLines[i].Replace("\r", "");
                    string ccwords = "";
                    string[] col = dataLines[i].Split('\t'); //分隔成字串陣列，tab==>"\t"

                    for (int j = 0; j < col.Length; j++)//欄位分別代表編號、食物名、單位量、克數、大卡
                    {

                        dataArray[i, j] = col[j];

                    }

                    int ff = dataArray[i, 1].GetHashCode();

                    ccwords = dataArray[i, 2] + "\t" + dataArray[i, 3] + "　" + dataArray[i, 4] + "大卡";//存入單字資料
                    bst.insert(ff, ccwords);

                }

                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)//搜尋資料
        {
            string food = textBox7.Text;
            string f = foodnum(food);
            richTextBox1.Text=f;
        }

        string foodnum(string key)
        {
            int c = key.GetHashCode();
            string result = bst.search(c);
            if (result == null)
            {
                return "目前還在新增中...";
            }
            return result;
        }

        private void button8_Click(object sender, EventArgs e)//清空資料
        {
            textBox7.Text = "";
            richTextBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string newst = test.Substring(0, 1); //第一個字
            test = test.Substring(1, test.Length - 1) + newst;
            //新字串每次從第二個字開始抓，然後把之前抓的第一個字補在最後
            label20.Text = test; //顯示字串
            label17.Text = test;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

    public class BST
    {
        public class Node
        {
            private int number;
            public string data;
            public Node rightLeaf;
            public Node leftLeaf;
            public string info_str = "";
            public int sCount = 0;


            public Node(int value, string indata)
            {
                number = value;
                data = indata;
                rightLeaf = null;
                leftLeaf = null;
            }

            public bool isLeaf(ref Node node)
            {
                return (node.rightLeaf == null && node.leftLeaf == null);

            }

            public void insertData(ref Node node, int key, string data)
            {
                if (node == null)
                {
                    node = new Node(key, data);

                }
                else if (node.number < key)
                {
                    insertData(ref node.rightLeaf, key, data);
                }

                else if (node.number > key)
                {
                    insertData(ref node.leftLeaf, key, data);
                }
            }

            public string search(Node node, int s)//找位置
            {

                if (node == null)
                    return "";

                if (node.number == s)
                {
                    return node.data;
                }
                else if (node.number < s)//小於number放右邊
                {
                    sCount++;
                    return search(node.rightLeaf, s);
                }
                else if (node.number > s)//大於number放左邊
                {
                    sCount++;
                    return search(node.leftLeaf, s);
                }

                return "Nothing found!!\n";
            }

            public void display(Node n)
            {
                if (n == null)
                    return;

                info_str = info_str + n.number + ", ";
                display(n.leftLeaf);
                display(n.rightLeaf);
            }

        }

        public class BinarySearchTree
        {
            private Node root;
            private int count;
            public int sCount = 0;

            public BinarySearchTree()//空的樹狀結構內無東西(就是button1第一個寫的那行)
            {
                root = null;
                count = 0;

            }
            public bool isEmpty()
            {
                return root == null;
            }

            public void insert(int k, string d)// k = key值類似編號  d = key值的內容
            {
                if (isEmpty())
                {
                    root = new Node(k, d);
                }
                else
                {
                    root.insertData(ref root, k, d);
                }

                count++;
            }

            public string search(int s)
            {
                root.sCount = 0;
                string result = root.search(root, s);
                this.sCount = root.sCount;
                return result;
            }

            public bool isLeaf()
            {
                if (!isEmpty())
                    return root.isLeaf(ref root);

                return true;
            }

            public string display()
            {
                root.info_str = "";
                if (!isEmpty())
                    root.display(root);
                return root.info_str;
            }

            public int Count()
            {
                return count;
            }
        }


    }

}
