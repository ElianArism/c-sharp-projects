namespace Calculator
{
    public partial class Calculator : Form
    {
        private string? operation;
        private decimal result = 0;
        public Calculator()
        {
            InitializeComponent();
        }



        private void equalsBtn_Click(object sender, EventArgs e)
        {

            this.preventPossibleAritmethicErrrors();

            this.doMathOperation();

            this.resetCalculator();
        }


        private void preventPossibleAritmethicErrrors()
        {
            if (this.operation == null)
            {
                return;
            }
            else if (operand1.Value == 0 && operand2.Value == 0 && operation == "/")
            {
                this.result = 0;
                resultTextBox.Text = this.result.ToString();
                return;
            }
        }

        private void doMathOperation()
        {
            switch (this.operation)
            {
                case "/":
                    this.result = operand1.Value / operand2.Value;
                    break;
                case "*":
                    this.result = operand1.Value * operand2.Value;
                    break;
                case "+":
                    this.result = operand1.Value + operand2.Value;
                    break;
                case "-":
                    this.result = operand1.Value - operand2.Value;
                    break;
                default:
                    this.result = 0;
                    break;
            }

            resultTextBox.Text = this.result.ToString();

        }
         
        private void resetCalculator()
        {
            operand2.Enabled = false;
            equalsBtn.Enabled = false;

            operand1.Value = 0;
            operand2.Value = 0;
        }

        private void operationToRealize_Click(object sender, EventArgs e)
        {
            this.operation = ((Button)sender).Text;
            operand2.Enabled = true;
            equalsBtn.Enabled = true;
        }
    }
}