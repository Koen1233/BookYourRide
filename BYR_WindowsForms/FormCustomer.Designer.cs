namespace BYR_WindowsForms
{
    partial class FormCustomer
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
            buttonBookaRide = new Button();
            listBoxAllRides = new ListBox();
            buttonCancelRide = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxDistance = new TextBox();
            textBoxPrice = new TextBox();
            buttonReturn = new Button();
            SuspendLayout();
            // 
            // buttonBookaRide
            // 
            buttonBookaRide.Location = new Point(64, 296);
            buttonBookaRide.Name = "buttonBookaRide";
            buttonBookaRide.Size = new Size(179, 49);
            buttonBookaRide.TabIndex = 0;
            buttonBookaRide.Text = "Book a ride";
            buttonBookaRide.UseVisualStyleBackColor = true;
            buttonBookaRide.Click += buttonBookaRide_Click;
            // 
            // listBoxAllRides
            // 
            listBoxAllRides.FormattingEnabled = true;
            listBoxAllRides.Location = new Point(64, 66);
            listBoxAllRides.Name = "listBoxAllRides";
            listBoxAllRides.Size = new Size(367, 224);
            listBoxAllRides.TabIndex = 1;
            listBoxAllRides.SelectedIndexChanged += listBoxAllRides_SelectedIndexChanged;
            listBoxAllRides.MouseDown += listBoxAllRides_MouseDown;
            // 
            // buttonCancelRide
            // 
            buttonCancelRide.Enabled = false;
            buttonCancelRide.Location = new Point(252, 296);
            buttonCancelRide.Name = "buttonCancelRide";
            buttonCancelRide.Size = new Size(179, 49);
            buttonCancelRide.TabIndex = 2;
            buttonCancelRide.Text = "Cancel ride";
            buttonCancelRide.UseVisualStyleBackColor = true;
            buttonCancelRide.Click += buttonCancelRide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "Upcoming rides:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Distance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 144);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(437, 101);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(125, 27);
            textBoxDistance.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(437, 167);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 7;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(12, 12);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(71, 26);
            buttonReturn.TabIndex = 8;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReturn);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDistance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelRide);
            Controls.Add(listBoxAllRides);
            Controls.Add(buttonBookaRide);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBookaRide;
        private ListBox listBoxAllRides;
        private Button buttonCancelRide;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDistance;
        private TextBox textBoxPrice;
        private Button buttonReturn;
    }
}