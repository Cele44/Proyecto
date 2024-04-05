namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioInterfaz));
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button5 = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 222);
            label9.Name = "label9";
            label9.Size = new Size(118, 18);
            label9.TabIndex = 71;
            label9.Text = "NOMBRE USER";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 253);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 157);
            label8.Name = "label8";
            label8.Size = new Size(100, 18);
            label8.TabIndex = 69;
            label8.Text = "ID PERSONA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 179);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 68;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(114, 446);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(160, 31);
            button3.TabIndex = 63;
            button3.Text = "INSERTAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.DialogResult = DialogResult.OK;
            button4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(114, 546);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(160, 31);
            button4.TabIndex = 62;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(207, 633);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(160, 31);
            button2.TabIndex = 61;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(114, 498);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 31);
            button1.TabIndex = 60;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 144);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(459, 533);
            dataGridView1.TabIndex = 57;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 133);
            panel1.TabIndex = 72;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(234, 177);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(50, 31);
            button5.TabIndex = 73;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 284);
            label7.Name = "label7";
            label7.Size = new Size(111, 18);
            label7.TabIndex = 75;
            label7.Text = "CONTRASEÑA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 319);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 74;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(44, 350);
            label10.Name = "label10";
            label10.Size = new Size(58, 18);
            label10.TabIndex = 77;
            label10.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(46, 383);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 27);
            dateTimePicker1.TabIndex = 78;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Location = new Point(-5, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 40);
            panel2.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(278, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(87, 70);
            panel7.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 36);
            label2.Name = "label2";
            label2.Size = new Size(230, 48);
            label2.TabIndex = 20;
            label2.Text = "USUARIO";
            // 
            // UsuarioInterfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(867, 692);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuarioInterfaz";
            Text = "UsuarioInterfaz";
            Load += UsuarioInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button5;
        private Label label7;
        private TextBox textBox3;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel7;
        private Label label2;
    }
}