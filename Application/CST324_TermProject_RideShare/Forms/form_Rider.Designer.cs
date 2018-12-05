namespace CST324_TermProject_RideShare
{
    partial class form_Rider
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
            this.components = new System.ComponentModel.Container();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.lb_streetaddress = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_UserPrompt_Location = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_destination = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_DesiredTime = new System.Windows.Forms.Label();
            this.btn_SubmitRideRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_title.Location = new System.Drawing.Point(118, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(562, 29);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Welcome, Rider! Please Create your Ride Request.";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(268, 118);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(24, 13);
            this.lb_City.TabIndex = 1;
            this.lb_City.Text = "City";
            this.lb_City.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_State
            // 
            this.cb_State.FormattingEnabled = true;
            this.cb_State.Items.AddRange(new object[] {
            "Klamath Falls",
            "Wilsonville"});
            this.cb_State.Location = new System.Drawing.Point(352, 115);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(121, 21);
            this.cb_State.TabIndex = 2;
            // 
            // lb_streetaddress
            // 
            this.lb_streetaddress.AutoSize = true;
            this.lb_streetaddress.Location = new System.Drawing.Point(268, 150);
            this.lb_streetaddress.Name = "lb_streetaddress";
            this.lb_streetaddress.Size = new System.Drawing.Size(76, 13);
            this.lb_streetaddress.TabIndex = 3;
            this.lb_streetaddress.Text = "Street Address";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lb_UserPrompt_Location
            // 
            this.lb_UserPrompt_Location.AutoSize = true;
            this.lb_UserPrompt_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_UserPrompt_Location.Location = new System.Drawing.Point(268, 79);
            this.lb_UserPrompt_Location.Name = "lb_UserPrompt_Location";
            this.lb_UserPrompt_Location.Size = new System.Drawing.Size(232, 24);
            this.lb_UserPrompt_Location.TabIndex = 6;
            this.lb_UserPrompt_Location.Text = "Please enter your location.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(271, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please enter your Desired Arrival time and Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination (Street Address)";
            // 
            // lb_destination
            // 
            this.lb_destination.Location = new System.Drawing.Point(430, 224);
            this.lb_destination.Name = "lb_destination";
            this.lb_destination.Size = new System.Drawing.Size(207, 20);
            this.lb_destination.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 11;
            // 
            // lb_DesiredTime
            // 
            this.lb_DesiredTime.AutoSize = true;
            this.lb_DesiredTime.Location = new System.Drawing.Point(271, 253);
            this.lb_DesiredTime.Name = "lb_DesiredTime";
            this.lb_DesiredTime.Size = new System.Drawing.Size(113, 13);
            this.lb_DesiredTime.TabIndex = 10;
            this.lb_DesiredTime.Text = "Desired Time of Arrival";
            // 
            // btn_SubmitRideRequest
            // 
            this.btn_SubmitRideRequest.Location = new System.Drawing.Point(272, 294);
            this.btn_SubmitRideRequest.Name = "btn_SubmitRideRequest";
            this.btn_SubmitRideRequest.Size = new System.Drawing.Size(285, 37);
            this.btn_SubmitRideRequest.TabIndex = 12;
            this.btn_SubmitRideRequest.Text = "Submit Ride Request";
            this.btn_SubmitRideRequest.UseVisualStyleBackColor = true;
            // 
            // form_Rider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SubmitRideRequest);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_DesiredTime);
            this.Controls.Add(this.lb_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_UserPrompt_Location);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_streetaddress);
            this.Controls.Add(this.cb_State);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_title);
            this.Name = "form_Rider";
            this.Text = "form_Rider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.ComboBox cb_State;
        private System.Windows.Forms.Label lb_streetaddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_UserPrompt_Location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lb_destination;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_DesiredTime;
        private System.Windows.Forms.Button btn_SubmitRideRequest;
    }
}