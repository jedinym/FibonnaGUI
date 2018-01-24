namespace fibonacci_numbers_GUI_2
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_print = new System.Windows.Forms.Button();
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.lbl_main = new System.Windows.Forms.Label();
            this.cbx_input = new System.Windows.Forms.ComboBox();
            this.lbl_typ = new System.Windows.Forms.Label();
            this.chb_medzery = new System.Windows.Forms.CheckBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.tbx_randmin = new System.Windows.Forms.TextBox();
            this.tbx_randmax = new System.Windows.Forms.TextBox();
            this.pnl_random = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.pnl_random.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(148, 20);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(118, 25);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Print Numbers";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // tbx_input
            // 
            this.tbx_input.Location = new System.Drawing.Point(3, 23);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(139, 20);
            this.tbx_input.TabIndex = 1;
            this.tbx_input.TextChanged += new System.EventHandler(this.tbx_input_TextChanged);
            // 
            // tbx_output
            // 
            this.tbx_output.Location = new System.Drawing.Point(3, 49);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.ReadOnly = true;
            this.tbx_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_output.Size = new System.Drawing.Size(263, 143);
            this.tbx_output.TabIndex = 2;
            this.tbx_output.TextChanged += new System.EventHandler(this.tbx_output_TextChanged);
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Location = new System.Drawing.Point(3, 2);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(217, 13);
            this.lbl_main.TabIndex = 3;
            this.lbl_main.Text = "Zadajte pocet Fibonacciho cisel na vypocet:\r\n";
            this.lbl_main.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_input
            // 
            this.cbx_input.FormattingEnabled = true;
            this.cbx_input.Items.AddRange(new object[] {
            "prvocisla",
            "fibonacciho cisla",
            "dokonale cisla",
            "parne cisla",
            "neparne cisla",
            "nahodne cisla"});
            this.cbx_input.Location = new System.Drawing.Point(12, 25);
            this.cbx_input.Name = "cbx_input";
            this.cbx_input.Size = new System.Drawing.Size(174, 21);
            this.cbx_input.TabIndex = 4;
            this.cbx_input.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_typ
            // 
            this.lbl_typ.AutoSize = true;
            this.lbl_typ.Location = new System.Drawing.Point(12, 9);
            this.lbl_typ.Name = "lbl_typ";
            this.lbl_typ.Size = new System.Drawing.Size(90, 13);
            this.lbl_typ.TabIndex = 5;
            this.lbl_typ.Text = "Zadajte typ cisel: ";
            // 
            // chb_medzery
            // 
            this.chb_medzery.AutoSize = true;
            this.chb_medzery.Location = new System.Drawing.Point(195, 27);
            this.chb_medzery.Name = "chb_medzery";
            this.chb_medzery.Size = new System.Drawing.Size(66, 17);
            this.chb_medzery.TabIndex = 6;
            this.chb_medzery.Text = "Medzery";
            this.chb_medzery.UseVisualStyleBackColor = true;
            this.chb_medzery.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.tbx_output);
            this.pnl_main.Controls.Add(this.btn_print);
            this.pnl_main.Controls.Add(this.tbx_input);
            this.pnl_main.Controls.Add(this.lbl_main);
            this.pnl_main.Location = new System.Drawing.Point(9, 78);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(269, 195);
            this.pnl_main.TabIndex = 7;
            // 
            // tbx_randmin
            // 
            this.tbx_randmin.Location = new System.Drawing.Point(7, 4);
            this.tbx_randmin.Name = "tbx_randmin";
            this.tbx_randmin.Size = new System.Drawing.Size(130, 20);
            this.tbx_randmin.TabIndex = 8;
            this.tbx_randmin.Text = "minimum";
            this.tbx_randmin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbx_randmax
            // 
            this.tbx_randmax.Location = new System.Drawing.Point(140, 4);
            this.tbx_randmax.Name = "tbx_randmax";
            this.tbx_randmax.Size = new System.Drawing.Size(130, 20);
            this.tbx_randmax.TabIndex = 9;
            this.tbx_randmax.Text = "maximum";
            // 
            // pnl_random
            // 
            this.pnl_random.Controls.Add(this.tbx_randmax);
            this.pnl_random.Controls.Add(this.tbx_randmin);
            this.pnl_random.Location = new System.Drawing.Point(5, 50);
            this.pnl_random.Name = "pnl_random";
            this.pnl_random.Size = new System.Drawing.Size(276, 27);
            this.pnl_random.TabIndex = 10;
            this.pnl_random.Visible = false;
            // 
            // frm_main
            // 
            this.AcceptButton = this.btn_print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 279);
            this.Controls.Add(this.pnl_random);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.chb_medzery);
            this.Controls.Add(this.lbl_typ);
            this.Controls.Add(this.cbx_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "FibonnaGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_random.ResumeLayout(false);
            this.pnl_random.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.ComboBox cbx_input;
        private System.Windows.Forms.Label lbl_typ;
        private System.Windows.Forms.CheckBox chb_medzery;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.TextBox tbx_randmin;
        private System.Windows.Forms.TextBox tbx_randmax;
        private System.Windows.Forms.Panel pnl_random;
    }
}

