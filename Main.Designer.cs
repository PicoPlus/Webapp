namespace PicoPlus.App
{
    partial class Main
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
            Dealtitle = new TextBox();
            FullName = new TextBox();
            DealPhone = new TextBox();
            button1 = new Button();
            DealAmount = new TextBox();
            Description = new TextBox();
            comboBox1 = new ComboBox();
            btnTrackDeal = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Dealtitle
            // 
            Dealtitle.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dealtitle.Location = new Point(23, 29);
            Dealtitle.Multiline = true;
            Dealtitle.Name = "Dealtitle";
            Dealtitle.PlaceholderText = "عنوان سفارش";
            Dealtitle.RightToLeft = RightToLeft.Yes;
            Dealtitle.Size = new Size(205, 39);
            Dealtitle.TabIndex = 0;
            Dealtitle.TextAlign = HorizontalAlignment.Center;
            // 
            // FullName
            // 
            FullName.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullName.Location = new Point(234, 29);
            FullName.Multiline = true;
            FullName.Name = "FullName";
            FullName.PlaceholderText = "نام و نام خانوادگی";
            FullName.RightToLeft = RightToLeft.Yes;
            FullName.Size = new Size(187, 39);
            FullName.TabIndex = 1;
            FullName.TextAlign = HorizontalAlignment.Center;
            // 
            // DealPhone
            // 
            DealPhone.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DealPhone.Location = new Point(429, 29);
            DealPhone.Multiline = true;
            DealPhone.Name = "DealPhone";
            DealPhone.PlaceholderText = "تلفن همراه";
            DealPhone.RightToLeft = RightToLeft.Yes;
            DealPhone.Size = new Size(205, 39);
            DealPhone.TabIndex = 2;
            DealPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(262, 266);
            button1.Name = "button1";
            button1.Size = new Size(141, 60);
            button1.TabIndex = 3;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DealAmount
            // 
            DealAmount.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DealAmount.Location = new Point(429, 83);
            DealAmount.Multiline = true;
            DealAmount.Name = "DealAmount";
            DealAmount.PlaceholderText = "مبلغ";
            DealAmount.RightToLeft = RightToLeft.Yes;
            DealAmount.Size = new Size(205, 39);
            DealAmount.TabIndex = 4;
            DealAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // Description
            // 
            Description.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Description.Location = new Point(48, 141);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.PlaceholderText = "توضیحات";
            Description.RightToLeft = RightToLeft.Yes;
            Description.Size = new Size(586, 110);
            Description.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "test";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "انجام شده", "در حال انجام", "کنسل شده", "در انتظار پرداخت" });
            comboBox1.Location = new Point(231, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "1";
            // 
            // btnTrackDeal
            // 
            btnTrackDeal.Font = new Font("B Yekan", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrackDeal.Location = new Point(409, 266);
            btnTrackDeal.Name = "btnTrackDeal";
            btnTrackDeal.Size = new Size(167, 60);
            btnTrackDeal.TabIndex = 7;
            btnTrackDeal.Text = "مشاهده سفارش";
            btnTrackDeal.UseVisualStyleBackColor = true;
            btnTrackDeal.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Yekan", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 293);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Yekan", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 293);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 9;
            label2.Text = ": شماره مشتری";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 349);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTrackDeal);
            Controls.Add(comboBox1);
            Controls.Add(Description);
            Controls.Add(DealAmount);
            Controls.Add(button1);
            Controls.Add(DealPhone);
            Controls.Add(FullName);
            Controls.Add(Dealtitle);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Dealtitle;
        private TextBox FullName;
        private TextBox DealPhone;
        private Button button1;
        private TextBox DealAmount;
        private TextBox Description;
        private ComboBox comboBox1;
        private Button btnTrackDeal;
        private Label label1;
        private Label label2;
    }
}