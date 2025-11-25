namespace task_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            picEye = new PictureBox();
            lblCVC = new Label();
            lblDate = new Label();
            lblName = new Label();
            lblCardNumber = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtCardNumber = new MaskedTextBox();
            txtName = new TextBox();
            txtCVC = new MaskedTextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(384, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(picEye);
            panel1.Controls.Add(lblCVC);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblCardNumber);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 279);
            panel1.TabIndex = 6;
            // 
            // picEye
            // 
            picEye.Image = Properties.Resources.eye_1_icon_icons_com_58901;
            picEye.Location = new Point(239, 3);
            picEye.Name = "picEye";
            picEye.Size = new Size(37, 39);
            picEye.SizeMode = PictureBoxSizeMode.Zoom;
            picEye.TabIndex = 6;
            picEye.TabStop = false;
            picEye.Click += picEye_Click;
            picEye.MouseEnter += picEye_MouseEnter;
            picEye.MouseLeave += picEye_MouseLeave;
            // 
            // lblCVC
            // 
            lblCVC.AutoSize = true;
            lblCVC.Font = new Font("Swis721 Ex BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCVC.Location = new Point(282, 15);
            lblCVC.Name = "lblCVC";
            lblCVC.Size = new Size(37, 18);
            lblCVC.TabIndex = 5;
            lblCVC.Text = "cvc";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Swis721 Ex BT", 9F);
            lblDate.Location = new Point(204, 251);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(40, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "--/--";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Swis721 Ex BT", 9F);
            lblName.Location = new Point(12, 234);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 18);
            lblName.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Swis721 Blk BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardNumber.Location = new Point(64, 132);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(124, 21);
            lblCardNumber.TabIndex = 2;
            lblCardNumber.Text = "---- ---- ---- ----";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Visa_icon_icons_com_60549;
            pictureBox2.Location = new Point(229, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cards_sim_chip_icon_157314;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            button1.Location = new Point(384, 242);
            button1.Name = "button1";
            button1.Size = new Size(286, 39);
            button1.TabIndex = 7;
            button1.Text = "Card Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(384, 27);
            txtCardNumber.Mask = "0000 0000 0000 0000";
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(286, 27);
            txtCardNumber.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Sitka Small", 10.2F, FontStyle.Bold);
            txtName.Location = new Point(384, 75);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name and surname";
            txtName.Size = new Size(286, 34);
            txtName.TabIndex = 2;
            // 
            // txtCVC
            // 
            txtCVC.Location = new Point(384, 192);
            txtCVC.Mask = "000";
            txtCVC.Name = "txtCVC";
            txtCVC.Size = new Size(286, 27);
            txtCVC.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Font = new Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(203, 309);
            button2.Name = "button2";
            button2.Size = new Size(286, 49);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(682, 363);
            Controls.Add(button2);
            Controls.Add(txtCVC);
            Controls.Add(txtCardNumber);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Information";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label lblCVC;
        private Label lblDate;
        private Label lblName;
        private Label lblCardNumber;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox picEye;
        private MaskedTextBox txtCardNumber;
        private TextBox txtName;
        private MaskedTextBox txtCVC;
        private Button button2;
    }
}
