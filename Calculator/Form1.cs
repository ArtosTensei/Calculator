namespace Calculator
{
    public partial class Form1 : Form
    {
        //объявление переменных
        Queue<string> QueueRequests = new Queue<string>();
        Queue<float> QueueResults = new Queue<float>();
        string temp = "";
        int control = 0;
        bool signBool = true;
        
        //иницилизация
        public Form1()
        {
            InitializeComponent();
            queueRequests.Text = "0";
            queueResults.Text = "0";
            time.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        //обработка нажатий только цифр
        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        //Обработка нажатия кнопок
        private void start_Click(object sender, EventArgs e)
        {
            temp += result.Text;
            QueueRequests.Enqueue(temp);
            temp = "";
            result.Text = "";
            buff.Text = "";
            control = 0;
            new Thread(calculate).Start();
        }

        private void one_Click(object sender, EventArgs e)
        {
            result.Text += "1";
            control = 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            result.Text += "2";
            control = 1;
        }

        private void three_Click(object sender, EventArgs e)
        {
            result.Text += "3";
            control = 1;
        }

        private void four_Click(object sender, EventArgs e)
        {
            result.Text += "4";
            control = 1;
        }

        private void five_Click(object sender, EventArgs e)
        {
            result.Text += "5";
            control = 1;
        }

        private void six_Click(object sender, EventArgs e)
        {
            result.Text += "6";
            control = 1;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            result.Text += "7";
            control = 1;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            result.Text += "8";
            control = 1;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            result.Text += "9";
            control = 1;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            result.Text += "0";
            control = 1;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            result.Text +=  ".";
            temp += " ";
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (signBool == true && result.Text != "")
            {
                result.Text = "-" + result.Text;
                signBool = false;
            }
            else if (signBool == false && result.Text != "")
            {
                result.Text = result.Text.Replace("-", "");
                signBool = true;
            }
        }

        //Обработка операций
        private void divide_Click(object sender, EventArgs e)
        {
            if (control != 0)
            {
                temp = result.Text + " / ";
                result.Clear();
                buff.Text = temp;
                control = 1;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (control != 0)
            {
                temp = result.Text + " x ";
                result.Clear();
                buff.Text = temp;
                control = 1;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (control != 0)
            {
                temp = result.Text + " - ";
                result.Clear();
                buff.Text = temp;
                control = 1;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (control != 0)
            {
                temp = result.Text + " + ";
                result.Clear();
                buff.Text = temp;
                control = 1;
            }
        }   
       
        //Вычисления
        private void calculate()
        {
            appendQueueResultsAdd(1);
            while (QueueRequests.Count > 0)
            {
                var request = QueueRequests.Dequeue();
                string[] requestArr = request.Split(" ");
                try
                {
                    switch (requestArr[1])
                    {
                        case "/":
                            QueueResults.Enqueue(float.Parse(requestArr[0]) / float.Parse(requestArr[2]));
                            break;
                        case "x":
                            QueueResults.Enqueue(float.Parse(requestArr[0]) * float.Parse(requestArr[2]));
                            break;
                        case "-":
                            QueueResults.Enqueue(float.Parse(requestArr[0]) - float.Parse(requestArr[2]));
                            break;
                        case "+":
                            QueueResults.Enqueue(float.Parse(requestArr[0]) + float.Parse(requestArr[2]));
                            break;
                        default:
                            break;
                    }
                }
                catch(DivideByZeroException)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }

                Thread.Sleep(int.Parse(time.Text) * 1000);
                appendResultBox(QueueResults.Dequeue());
                appendQueueResultsAndQueueRequestsMinus(1);
            }
        }

        //Вывод результата
        public void appendResultBox(float value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<float>(appendResultBox), new object[] { value });
                return;
            }

            buff.Text = value.ToString();
        }

        //Контроль очередей
        public void appendQueueResultsAdd(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(appendQueueResultsAdd), new object[] { value });
                return;
            }
            
            queueResults.Text = (Int32.Parse(queueResults.Text) + value).ToString();
            queueRequests.Text = ((Int32.Parse(queueRequests.Text) + value)).ToString();
        }
        public void appendQueueResultsAndQueueRequestsMinus(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(appendQueueResultsAndQueueRequestsMinus), new object[] { value });
                return;
            }

            queueResults.Text = ((Int32.Parse(queueResults.Text) - value)).ToString();
            queueRequests.Text = ((Int32.Parse(queueRequests.Text) - value)).ToString();
        }
    }
}