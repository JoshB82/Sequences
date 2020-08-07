using System.Windows.Forms;

namespace Sequences
{
    public partial class Main : Form
    {
        private int start_value = 1;
        private int finish_value = 5;

        public Main() => InitializeComponent();

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) => Update_Sequence();

        private void Sequence_Start_ValueChanged(object sender, System.EventArgs e)
        {
            start_value = (int)Sequence_Start.Value;
            if (start_value > finish_value)
            {
                start_value = finish_value;
                Sequence_Start.Value = (decimal)start_value;
            }
            Update_Sequence();
        }

        private void Sequence_Finish_ValueChanged(object sender, System.EventArgs e)
        {
            finish_value = (int)Sequence_Finish.Value;
            if (start_value > finish_value)
            {
                finish_value = start_value;
                Sequence_Finish.Value = (decimal)finish_value;
            }
            Update_Sequence();
        }

        private void Update_Sequence()
        {
            int index = Sequence_Names.SelectedIndex;

            double[] sequence_result = new double[0];

            switch (index)
            {
                case 0:
                    sequence_result = Fibonacci(start_value, finish_value);
                    break;
                case 1:
                    //sequence_result = Primes(start, finish);
                    break;
            }

            string output = "";
            for (int i = 0; i < sequence_result.Length; i++)
            {
                output += sequence_result[i] + ((i == sequence_result.Length - 1) ? "" : ", ");
            }

            Result_Text.Text = output;
        }

        #region Sequence Generators

        private double[] Fibonacci(int start, int finish)
        {
            double[] terms = new double[finish];
            double[] result_terms = new double[finish - start + 1];
            terms[0] = 1; terms[1] = 1;

            for (int i = 2; i < finish; i++) terms[i] = terms[i - 1] + terms[i - 2];
            for (int i = start; i <= finish; i++) result_terms[i - start] = terms[i - 1];

            return result_terms;
        }

        //private double[] Primes(int start, int finish)
        //{

        //}

        #endregion
    }
}