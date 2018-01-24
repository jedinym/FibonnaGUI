using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci_numbers_GUI_2
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_input.SelectedIndex = 0;
        }

        private void tbx_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            vykonaj();
        }
        private void vykonaj()
        {
            switch (cbx_input.Text)
            {
                case "fibonacciho cisla":
                    tbx_output.Clear();
                    fibonacci();
                    break;
                case "prvocisla":
                    tbx_output.Clear();
                    prvocisla();
                    break;
                case "dokonale cisla":
                    tbx_output.Clear();
                    dokonale();
                    break;
                case "parne cisla":
                    tbx_output.Clear();
                    parne();
                    break;
                case "neparne cisla":
                    tbx_output.Clear();
                    neparne();
                    break;
                case "nahodne cisla":
                    tbx_output.Clear();
                    nahodne();
                    break;
            }
        }
        private void fibonacci()
        {
            bool a = check_empty();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_fibonacci(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_fibonacci(uint d) //d = pocet
        {
            ulong a = 0;
            ulong b = 1;
            ulong[] c = new ulong[d]; //d = pocet cisel na vypocet
            for (int i = 0; i < d; ++i)
            {
                c[i] = a + b;
                a = b;
                b = c[i];
            }
            return c;
        }
        private void prvocisla()
        {
            bool a = check_empty();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_prvocisla(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_prvocisla(uint d)  //d = pocet cisel na vypocet
        {
            List<ulong> primes = new List<ulong>();
            primes.Add(2);
            ulong next_prime = 3;
            while (primes.Count < d)
            {
                int sqrt = (int)Math.Sqrt(next_prime);
                bool is_prime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (next_prime % primes[i] == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if (is_prime)
                {
                    primes.Add(next_prime);
                }
                next_prime += 2;
            }
            return primes.ToArray();
        }
        private void dokonale()
        {
            bool a = check_empty();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_dokonale(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_dokonale(uint d) //d = pocet
        {
            int pocet_doko = 0;
            List<ulong> doko = new List<ulong>();
            ulong test_cislo = 6;
            while (pocet_doko < d)
            {
                List<ulong> delitele = new List<ulong>();
                for (uint i = 1; i <= (test_cislo / 2); ++i)
                {
                    if (test_cislo % i == 0)
                    {
                        delitele.Add(i);
                    }
                }
                ulong sum = scitaj(delitele);
                if (sum == test_cislo)
                {
                    ++pocet_doko;
                    doko.Add(test_cislo);
                }
                ++test_cislo;
            }
            return doko.ToArray();
        }
        private ulong scitaj(List<ulong> a)
        {
            ulong sum = 0;
            for (int i = 0; i < a.Count; ++i)
            {
                sum += a[i];
            }
            return sum;
        }
        private void parne()
        {
            bool a = check_empty();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_parne(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_parne(uint d) //d = pocet
        {
            List<ulong> parne = new List<ulong>();
            for (ulong i = 2; i <= (d * 2); i += 2)
            {
                parne.Add(i);
            }
            return parne.ToArray();
        }
        private void neparne()
        {
            bool a = check_empty();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_neparne(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_neparne(uint d) //d = pocet
        {
            List<ulong> parne = new List<ulong>();
            for (ulong i = 1; i <= (d * 2); i += 2)
            {
                parne.Add(i);
            }
            return parne.ToArray();
        }
        private void nahodne()
        {
            bool a = check_empty_rand();
            if (a)
            {
                uint pocet = Convert.ToUInt32(tbx_input.Text);
                ulong[] pole = get_nahodne(pocet);
                vypis_cisla(pole);
            }
        }
        private ulong[] get_nahodne(uint d)
        {
            int randmin = Convert.ToInt32(tbx_randmin.Text);
            int randmax = Convert.ToInt32(tbx_randmax.Text);
            ulong[] a = new ulong[d];
            Random rnd = new Random();
            for (int i = 0; i < d; ++i)
            {
                a[i] = Convert.ToUInt64(rnd.Next(randmin, randmax + 1));
            }
            return a;
        }
        private bool check_empty_rand()
        { 
            bool d;
            uint a = 0;
            uint b = 0;
            uint c = 0;
            try
            {
                a = Convert.ToUInt32(tbx_input.Text);
                b = Convert.ToUInt32(tbx_randmin.Text);
                c = Convert.ToUInt32(tbx_randmax.Text);
            }
            catch (Exception ex)
            {

                if (ex is System.FormatException || ex is System.OverflowException)
                {
                    tbx_input.Clear();
                    d = false;
                }
            }
            d = (b >= c) ? false : true;
            return d;
        }
        private bool check_empty()
        {
            uint pocet = 0;
            try
            {
                pocet = Convert.ToUInt32(tbx_input.Text);
            }
            catch (Exception ex)
            {
                
                if (ex is System.FormatException || ex is System.OverflowException)
                {
                    tbx_input.Clear();
                    return false;
                }        
            }
            return true;
        }
        private void vypis_cisla(ulong[] a) //a = pole
        {
            bool b = chb_medzery.Checked;
            if (b)
            {           
                foreach (ulong prvok in a)
                {
                    tbx_output.AppendText(Convert.ToString(prvok) + " ");
                }
            }
            else
            {
                for (int i = 0; i < a.Length; ++i)
                {
                    //tbx_output.AppendText(Convert.ToString(a[i]) + "\n");
                    tbx_output.AppendText(Convert.ToString(a[i]) + Environment.NewLine);
                }
            }         
        }
        private void tbx_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Size ns = new Size(301, 318);
            Size os = new Size(301, 292);

            switch (cbx_input.Text)
            {
                case "fibonacciho cisla":
                    lbl_main.Text = "Zadajte pocet Fibonacciho cisel na vypocet:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = os;
                    break;
                case "prvocisla":
                    lbl_main.Text = "Zadajte pocet prvocisel na vypocet:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = os;
                    break;
                case "dokonale cisla":
                    lbl_main.Text = "Zadajte pocet dokonalych cisel na vypocet:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = os;
                    break;
                case "parne cisla":
                    lbl_main.Text = "Zadajte pocet parnych cisel na vypocet:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = os;
                    break;
                case "neparne cisla":
                    lbl_main.Text = "Zadajte pocet neparnych cisel na vypocet:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = os;
                    break;
                case "nahodne cisla":
                    lbl_main.Text = "Zadajte pocet nahodnych cisel:";
                    pnl_main.Location = shift();
                    pnl_random.Visible = check_random();
                    this.Size = ns;
                    break;
            }
            vykonaj();   //ak sa pouzije tak po zmeneni typu cisla ho rovno vyrata; otravne pri vacsich cislach asi
        }
        private Point shift()
        {
            Point ndp_xy = new Point(9, 52)
            {
                Y = (check_random()) ? 78 : 52
            };
            return ndp_xy;
        }
        private bool check_random() //skontroluje ci su vybrane nahodne cisla v cbx_input
        {
            bool a;
            a = (cbx_input.SelectedIndex == 5) ? true : false;
            return a; 
        }
        private void change_spacing()
        {
            bool a = chb_medzery.Checked; // if true => chcem medzery
            StringBuilder sb = new StringBuilder();

            sb.Append(tbx_output.Text);

            if (a)
            {
                sb.Replace(Environment.NewLine, " ");
            }
            else
            {
                sb.Replace(" ", Environment.NewLine);
            }

            tbx_output.Text = sb.ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            change_spacing();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
