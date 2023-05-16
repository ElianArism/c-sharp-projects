namespace UnitConverter
{
    public partial class UnitConverter : Form
    {
        private Conversor conversor = new Conversor();
  
        public UnitConverter()
        {
            InitializeComponent();
        }

        private void UnitConverter_Load(object sender, EventArgs e)
        {
            // Distance
            baseMeterUnit.Items.Add("Kilometer");
            baseMeterUnit.Items.Add("Meter");
            baseMeterUnit.Items.Add("Centimeter");

            baseMeterUnit.SelectedIndex = 1; 

            convertToMeterUnit.Items.Add("Kilometer");
            convertToMeterUnit.Items.Add("Meter");
            convertToMeterUnit.Items.Add("Centimeter");

            convertToMeterUnit.SelectedIndex = 0;

            // Liquid
            baseLiterUnit.Items.Add("Liter");
            baseLiterUnit.Items.Add("Centiliter");
            baseLiterUnit.Items.Add("Mililiter");

            baseLiterUnit.SelectedIndex = 0;

            convertToLiterUnit.Items.Add("Liter");
            convertToLiterUnit.Items.Add("Centiliter");
            convertToLiterUnit.Items.Add("Mililiter");

            convertToLiterUnit.SelectedIndex = 2;
            // Temperature
            baseTemperatureUnit.Items.Add("Celsius");
            baseTemperatureUnit.Items.Add("Farenheit");

            baseTemperatureUnit.SelectedIndex = 0;

            convertToTemperatureUnit.Items.Add("Celsius");
            convertToTemperatureUnit.Items.Add("Farenheit");

            convertToTemperatureUnit.SelectedIndex = 0;
        }

        private void convertMeterBtn_Click(object sender, EventArgs e)
        {
            if (
                this.areInvalidUnits(
                    baseMeterUnit.SelectedIndex, 
                    convertToMeterUnit.SelectedIndex
                )
            ) return;

            decimal value = this.conversor.DistanceConversor(
                baseMeterUnit.Items[baseMeterUnit.SelectedIndex].ToString(),
                convertToMeterUnit.Items[convertToMeterUnit.SelectedIndex].ToString(),
                meterInput.Value
            ); 

            textBox1.Text = value.ToString();
            
        }

        private void convertTemperatureBtn_Click(object sender, EventArgs e)
        {
            if (
               this.areInvalidUnits(
                   baseTemperatureUnit.SelectedIndex,
                   convertToTemperatureUnit.SelectedIndex
               )
           ) return;

            decimal value = this.conversor.TemperatureConversor(
                baseTemperatureUnit.Items[baseTemperatureUnit.SelectedIndex].ToString(),
                convertToTemperatureUnit.Items[convertToTemperatureUnit.SelectedIndex].ToString(),
                temperatureInput.Value
            );

            textBox1.Text = value.ToString();

        }

        private void convertLiterBtn_Click(object sender, EventArgs e)
        {
            if (
               this.areInvalidUnits(
                   baseLiterUnit.SelectedIndex,
                   convertToLiterUnit.SelectedIndex
               )
           ) return;

            decimal value = this.conversor.LiquidConversor(
                baseLiterUnit.Items[baseLiterUnit.SelectedIndex].ToString(),
                convertToLiterUnit.Items[convertToLiterUnit.SelectedIndex].ToString(),
                literInput.Value
            );

            textBox1.Text = value.ToString();

        }

        private Boolean areInvalidUnits (int from, int to)
        {
            return (from == -1 || to == -1);  
        }
    }
}