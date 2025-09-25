namespace BYR_WindowsForms
{
    partial class FormEmployee
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
            buttonReturn = new Button();
            textBoxPrice = new TextBox();
            textBoxDistance = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancelRide = new Button();
            listBoxAllRides = new ListBox();
            buttonViewPersonnel = new Button();
            buttonViewVehicles = new Button();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(12, 12);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(71, 26);
            buttonReturn.TabIndex = 17;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(456, 168);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 16;
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(456, 102);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(125, 27);
            textBoxDistance.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 145);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 14;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "Distance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 12;
            label1.Text = "Upcoming rides:";
            // 
            // buttonCancelRide
            // 
            buttonCancelRide.Enabled = false;
            buttonCancelRide.Location = new Point(271, 297);
            buttonCancelRide.Name = "buttonCancelRide";
            buttonCancelRide.Size = new Size(179, 49);
            buttonCancelRide.TabIndex = 11;
            buttonCancelRide.Text = "Cancel ride";
            buttonCancelRide.UseVisualStyleBackColor = true;
            buttonCancelRide.Click += buttonCancelRide_Click;
            // 
            // listBoxAllRides
            // 
            listBoxAllRides.FormattingEnabled = true;
            listBoxAllRides.Location = new Point(83, 67);
            listBoxAllRides.Name = "listBoxAllRides";
            listBoxAllRides.Size = new Size(367, 224);
            listBoxAllRides.TabIndex = 10;
            listBoxAllRides.SelectedIndexChanged += listBoxAllRides_SelectedIndexChanged;
            listBoxAllRides.MouseDown += listBoxAllRides_MouseDown;
            // 
            // buttonViewPersonnel
            // 
            buttonViewPersonnel.Enabled = false;
            buttonViewPersonnel.Location = new Point(86, 297);
            buttonViewPersonnel.Name = "buttonViewPersonnel";
            buttonViewPersonnel.Size = new Size(179, 49);
            buttonViewPersonnel.TabIndex = 18;
            buttonViewPersonnel.Text = "View all personnel";
            buttonViewPersonnel.UseVisualStyleBackColor = true;
            buttonViewPersonnel.Click += buttonViewPersonnel_Click;
            // 
            // buttonViewVehicles
            // 
            buttonViewVehicles.Enabled = false;
            buttonViewVehicles.Location = new Point(86, 352);
            buttonViewVehicles.Name = "buttonViewVehicles";
            buttonViewVehicles.Size = new Size(179, 49);
            buttonViewVehicles.TabIndex = 19;
            buttonViewVehicles.Text = "View all vehicles";
            buttonViewVehicles.UseVisualStyleBackColor = true;
            buttonViewVehicles.Click += buttonViewVehicles_Click;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonViewVehicles);
            Controls.Add(buttonViewPersonnel);
            Controls.Add(buttonReturn);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDistance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelRide);
            Controls.Add(listBoxAllRides);
            Name = "FormEmployee";
            Text = "FormEmployee";
            Load += FormEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private TextBox textBoxPrice;
        private TextBox textBoxDistance;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancelRide;
        private ListBox listBoxAllRides;
        private Button buttonViewPersonnel;
        private Button buttonViewVehicles;
    }
}