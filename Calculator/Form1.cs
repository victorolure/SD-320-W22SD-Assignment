using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Double ResultOutput = 0;
        private string OperationApplied = "";
        private bool IsOperationApplied = false;
        private bool HasErrored = false;
        private bool ClearOnNextInput = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (HasErrored || ClearOnNextInput)
            {
                CalcInput.Clear();
                HasErrored = false;
                ClearOnNextInput = false;
            }

            if(CalcInput.Text == "0" || IsOperationApplied)
            
                CalcInput.Clear();
                IsOperationApplied = false;
                Button button  = (Button)sender;
                if(button.Text == ".")
                {
                    if (!CalcInput.Text.Contains("."))
                    {
                        CalcInput.Text+= button.Text;
                    }
                }
                else
                {
                    CalcInput.Text = CalcInput.Text + button.Text;
                }               
            
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(ResultOutput != 0)
            {
                EqualButton.PerformClick();
                OperationApplied = button.Text;
                //ResultOutput = Double.Parse(CalcInput.Text);
                CurrentOutput.Text = ResultOutput + " " + OperationApplied; ;
                IsOperationApplied = true;
            }
            else
            {
                OperationApplied = button.Text;
                ResultOutput = Double.Parse(CalcInput.Text);
                CurrentOutput.Text = ResultOutput + " " + OperationApplied; ;
                IsOperationApplied = true;
            }
            
        }

        private void clearValue_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text== "CE")
            {
                CalcInput.Text = "0";
            }
            else if(button.Text== "C")
            {
                CalcInput.Text = "0";
                CurrentOutput.Text = "";
                ResultOutput = 0;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (OperationApplied)
            {
                case "+":
                    CalcInput.Text = (ResultOutput + Double.Parse(CalcInput.Text)).ToString();
                    break;
                case "-":
                    CalcInput.Text = (ResultOutput - Double.Parse(CalcInput.Text)).ToString();
                    break;
                case "/":
                    CalcInput.Text = (ResultOutput / Double.Parse(CalcInput.Text)).ToString();
                    break;
                case "x":
                    CalcInput.Text = (ResultOutput * Double.Parse(CalcInput.Text)).ToString();
                    break;
                default:
                    break;
            }
            ResultOutput = Double.Parse(CalcInput.Text);
            CurrentOutput.Text = "";
            ClearOnNextInput = true;
            OperationApplied = "";
            IsOperationApplied = false;
        }

        private void DecButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CalcInput.Text.Any(t => !t.Equals('0') && !t.Equals('1')))
                {
                    ThrowError();
                }
                else
                {

                    ResultOutput = BinaryToNum(Int32.Parse(CalcInput.Text));
                    CalcInput.Text = ResultOutput.ToString();
                }
                
            }
            catch
            {
                HasErrored = true;
                CalcInput.Text = "Error";
            }
        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {
            char[] binArray = CalcInput.Text.ToCharArray();
            
            try
            {
                
                    
                 ResultOutput = NumToBinary(Int32.Parse(CalcInput.Text));
                 CalcInput.Text = ResultOutput.ToString();
                
                
            }
            catch(Exception ex)
            {
                ThrowError();
                
            }
            
        }

        private void ThrowError()
        {
            HasErrored = true;
            CalcInput.Text = "ERROR";
        }
        

        private double BinaryToNum(int binary)
        {
            string binaryString = binary.ToString();
            char[] chars = binaryString.ToCharArray();
            double result = 0;
            int power = binaryString.Length;
            int currentIndex;
            double multiplier;


            for (int i = 0; i < chars.Length; i++)
            {
                power = power - 1;
                currentIndex = Int32.Parse(chars[i].ToString());
                multiplier = (Math.Pow(2, power));
                result += currentIndex * multiplier;
            }
            return result;



        }

        private double NumToBinary(int num)
        {
            StringBuilder sb = new StringBuilder();
            int binaryHolder;
            while (num > 0)
            {
                binaryHolder = num % 2;
                sb.Insert(0, binaryHolder);
                num = num / 2;
            }
            return Double.Parse(sb.ToString());
        }

    }
}