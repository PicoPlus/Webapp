namespace PicoPlus.App
{
    partial class SearchDeal
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
            btnSearch = new Button();
            TrackingCode = new TextBox();
            FullName = new TextBox();
            PhoneNumber = new TextBox();
            DealTitle = new TextBox();
            DealAmount = new TextBox();
            DealDescription = new TextBox();
            DealStage = new ComboBox();
            btnUpdate = new Button();
            LblCreateDate = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(251, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.Yes;
            btnSearch.Size = new Size(196, 44);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // TrackingCode
            // 
            TrackingCode.Location = new Point(467, 12);
            TrackingCode.Multiline = true;
            TrackingCode.Name = "TrackingCode";
            TrackingCode.Size = new Size(253, 44);
            TrackingCode.TabIndex = 1;
            // 
            // FullName
            // 
            FullName.Location = new Point(544, 97);
            FullName.Multiline = true;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Size = new Size(176, 35);
            FullName.TabIndex = 2;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(340, 97);
            PhoneNumber.Multiline = true;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Size = new Size(176, 35);
            PhoneNumber.TabIndex = 3;
            // 
            // DealTitle
            // 
            DealTitle.Location = new Point(40, 97);
            DealTitle.Multiline = true;
            DealTitle.Name = "DealTitle";
            DealTitle.Size = new Size(258, 35);
            DealTitle.TabIndex = 4;
            // 
            // DealAmount
            // 
            DealAmount.Location = new Point(544, 164);
            DealAmount.Multiline = true;
            DealAmount.Name = "DealAmount";
            DealAmount.Size = new Size(176, 35);
            DealAmount.TabIndex = 5;
            // 
            // DealDescription
            // 
            DealDescription.Font = new Font("B Yekan", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DealDescription.Location = new Point(249, 218);
            DealDescription.Multiline = true;
            DealDescription.Name = "DealDescription";
            DealDescription.RightToLeft = RightToLeft.Yes;
            DealDescription.ScrollBars = ScrollBars.Both;
            DealDescription.Size = new Size(471, 111);
            DealDescription.TabIndex = 6;
            // 
            // DealStage
            // 
            DealStage.DisplayMember = "test";
            DealStage.DropDownStyle = ComboBoxStyle.DropDownList;
            DealStage.FormattingEnabled = true;
            DealStage.Items.AddRange(new object[] { "انجام شده", "در حال انجام", "کنسل شده", "در انتظار پرداخت", "در انتظار بررسی" });
            DealStage.Location = new Point(326, 176);
            DealStage.Name = "DealStage";
            DealStage.RightToLeft = RightToLeft.Yes;
            DealStage.Size = new Size(190, 23);
            DealStage.TabIndex = 8;
            DealStage.ValueMember = "1";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(25, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.Yes;
            btnUpdate.Size = new Size(196, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "بروزرسانی";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // LblCreateDate
            // 
            LblCreateDate.AutoSize = true;
            LblCreateDate.Font = new Font("B Yekan", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblCreateDate.Location = new Point(54, 27);
            LblCreateDate.Name = "LblCreateDate";
            LblCreateDate.Size = new Size(47, 20);
            LblCreateDate.TabIndex = 10;
            LblCreateDate.Text = "label1";
            LblCreateDate.Click += LblCreateDate_Click;
            // 
            // SearchDeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 376);
            Controls.Add(LblCreateDate);
            Controls.Add(btnUpdate);
            Controls.Add(DealStage);
            Controls.Add(DealDescription);
            Controls.Add(DealAmount);
            Controls.Add(DealTitle);
            Controls.Add(PhoneNumber);
            Controls.Add(FullName);
            Controls.Add(TrackingCode);
            Controls.Add(btnSearch);
            Name = "SearchDeal";
            Text = "ViewLines";
            Load += SearchDeal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox TrackingCode;
        private TextBox FullName;
        private TextBox PhoneNumber;
        private TextBox DealTitle;
        private TextBox DealAmount;
        private TextBox DealDescription;
        private ComboBox DealStage;
        private Button btnUpdate;
        private Label LblCreateDate;
    }
}