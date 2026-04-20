namespace WindowsFormsApp1
{
    partial class MainMenu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu1));
            this.GrbSize = new System.Windows.Forms.GroupBox();
            this.RD_Medium = new System.Windows.Forms.RadioButton();
            this.RD_Larg = new System.Windows.Forms.RadioButton();
            this.RD_Small = new System.Windows.Forms.RadioButton();
            this.GRB_Curst = new System.Windows.Forms.GroupBox();
            this.RD_ThickCurst = new System.Windows.Forms.RadioButton();
            this.RD_ThinCrust = new System.Windows.Forms.RadioButton();
            this.Grb_Topping = new System.Windows.Forms.GroupBox();
            this.CHB_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.CHB_Olives = new System.Windows.Forms.CheckBox();
            this.CHB_Onion = new System.Windows.Forms.CheckBox();
            this.CHB_Tomatoes = new System.Windows.Forms.CheckBox();
            this.CHB_Musgrooms = new System.Windows.Forms.CheckBox();
            this.CHB_ExtraChees = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RDB_Takeout = new System.Windows.Forms.RadioButton();
            this.RDB_EatIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Price = new System.Windows.Forms.Label();
            this.BUT_OrderPizza = new System.Windows.Forms.Button();
            this.BUT_ResetForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Imoge = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GrbSize.SuspendLayout();
            this.GRB_Curst.SuspendLayout();
            this.Grb_Topping.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbSize
            // 
            this.GrbSize.BackColor = System.Drawing.Color.Transparent;
            this.GrbSize.Controls.Add(this.RD_Medium);
            this.GrbSize.Controls.Add(this.RD_Larg);
            this.GrbSize.Controls.Add(this.RD_Small);
            this.GrbSize.Font = new System.Drawing.Font("Arial Nova", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbSize.ForeColor = System.Drawing.Color.LightGray;
            this.GrbSize.Location = new System.Drawing.Point(68, 123);
            this.GrbSize.Name = "GrbSize";
            this.GrbSize.Size = new System.Drawing.Size(257, 154);
            this.GrbSize.TabIndex = 0;
            this.GrbSize.TabStop = false;
            this.GrbSize.Text = "Size";
            this.GrbSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RD_Medium
            // 
            this.RD_Medium.AutoSize = true;
            this.RD_Medium.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_Medium.Location = new System.Drawing.Point(8, 85);
            this.RD_Medium.Name = "RD_Medium";
            this.RD_Medium.Size = new System.Drawing.Size(100, 23);
            this.RD_Medium.TabIndex = 9;
            this.RD_Medium.Tag = "10";
            this.RD_Medium.Text = "Meduim";
            this.RD_Medium.UseVisualStyleBackColor = false;
            this.RD_Medium.UseWaitCursor = true;
            // 
            // RD_Larg
            // 
            this.RD_Larg.AutoSize = true;
            this.RD_Larg.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_Larg.Location = new System.Drawing.Point(6, 125);
            this.RD_Larg.Name = "RD_Larg";
            this.RD_Larg.Size = new System.Drawing.Size(79, 23);
            this.RD_Larg.TabIndex = 8;
            this.RD_Larg.Tag = "30";
            this.RD_Larg.Text = "Large";
            this.RD_Larg.UseVisualStyleBackColor = true;
            // 
            // RD_Small
            // 
            this.RD_Small.AutoSize = true;
            this.RD_Small.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_Small.Location = new System.Drawing.Point(6, 41);
            this.RD_Small.Name = "RD_Small";
            this.RD_Small.Size = new System.Drawing.Size(77, 23);
            this.RD_Small.TabIndex = 7;
            this.RD_Small.Tag = "10";
            this.RD_Small.Text = "Small";
            this.RD_Small.UseVisualStyleBackColor = true;
            this.RD_Small.CheckedChanged += new System.EventHandler(this.RD_Small_CheckedChanged);
            // 
            // GRB_Curst
            // 
            this.GRB_Curst.BackColor = System.Drawing.Color.Transparent;
            this.GRB_Curst.Controls.Add(this.RD_ThickCurst);
            this.GRB_Curst.Controls.Add(this.RD_ThinCrust);
            this.GRB_Curst.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRB_Curst.ForeColor = System.Drawing.Color.LightGray;
            this.GRB_Curst.Location = new System.Drawing.Point(805, 123);
            this.GRB_Curst.Name = "GRB_Curst";
            this.GRB_Curst.Size = new System.Drawing.Size(257, 154);
            this.GRB_Curst.TabIndex = 1;
            this.GRB_Curst.TabStop = false;
            this.GRB_Curst.Text = "Crust Type";
            this.GRB_Curst.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RD_ThickCurst
            // 
            this.RD_ThickCurst.AutoSize = true;
            this.RD_ThickCurst.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_ThickCurst.Location = new System.Drawing.Point(6, 92);
            this.RD_ThickCurst.Name = "RD_ThickCurst";
            this.RD_ThickCurst.Size = new System.Drawing.Size(122, 23);
            this.RD_ThickCurst.TabIndex = 4;
            this.RD_ThickCurst.TabStop = true;
            this.RD_ThickCurst.Tag = "5";
            this.RD_ThickCurst.Text = "Thick Crust";
            this.RD_ThickCurst.UseVisualStyleBackColor = true;
            this.RD_ThickCurst.CheckedChanged += new System.EventHandler(this.RD_ThickCurst_CheckedChanged);
            // 
            // RD_ThinCrust
            // 
            this.RD_ThinCrust.AutoSize = true;
            this.RD_ThinCrust.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD_ThinCrust.Location = new System.Drawing.Point(6, 41);
            this.RD_ThinCrust.Name = "RD_ThinCrust";
            this.RD_ThinCrust.Size = new System.Drawing.Size(113, 23);
            this.RD_ThinCrust.TabIndex = 0;
            this.RD_ThinCrust.TabStop = true;
            this.RD_ThinCrust.Tag = "0";
            this.RD_ThinCrust.Text = "Thin Crust";
            this.RD_ThinCrust.UseVisualStyleBackColor = true;
            this.RD_ThinCrust.CheckedChanged += new System.EventHandler(this.RD_ThinCrust_CheckedChanged);
            // 
            // Grb_Topping
            // 
            this.Grb_Topping.BackColor = System.Drawing.Color.Transparent;
            this.Grb_Topping.Controls.Add(this.CHB_GreenPeppers);
            this.Grb_Topping.Controls.Add(this.CHB_Olives);
            this.Grb_Topping.Controls.Add(this.CHB_Onion);
            this.Grb_Topping.Controls.Add(this.CHB_Tomatoes);
            this.Grb_Topping.Controls.Add(this.CHB_Musgrooms);
            this.Grb_Topping.Controls.Add(this.CHB_ExtraChees);
            this.Grb_Topping.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grb_Topping.ForeColor = System.Drawing.Color.SandyBrown;
            this.Grb_Topping.Location = new System.Drawing.Point(342, 298);
            this.Grb_Topping.Name = "Grb_Topping";
            this.Grb_Topping.Size = new System.Drawing.Size(455, 169);
            this.Grb_Topping.TabIndex = 2;
            this.Grb_Topping.TabStop = false;
            this.Grb_Topping.Text = "Topping";
            // 
            // CHB_GreenPeppers
            // 
            this.CHB_GreenPeppers.AutoSize = true;
            this.CHB_GreenPeppers.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_GreenPeppers.Location = new System.Drawing.Point(204, 120);
            this.CHB_GreenPeppers.Name = "CHB_GreenPeppers";
            this.CHB_GreenPeppers.Size = new System.Drawing.Size(237, 44);
            this.CHB_GreenPeppers.TabIndex = 5;
            this.CHB_GreenPeppers.Tag = "3";
            this.CHB_GreenPeppers.Text = "Green Peppers";
            this.CHB_GreenPeppers.UseVisualStyleBackColor = true;
            this.CHB_GreenPeppers.CheckedChanged += new System.EventHandler(this.CHB_GreenPeppers_CheckedChanged);
            // 
            // CHB_Olives
            // 
            this.CHB_Olives.AutoSize = true;
            this.CHB_Olives.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Olives.Location = new System.Drawing.Point(204, 74);
            this.CHB_Olives.Name = "CHB_Olives";
            this.CHB_Olives.Size = new System.Drawing.Size(119, 44);
            this.CHB_Olives.TabIndex = 4;
            this.CHB_Olives.Tag = "3";
            this.CHB_Olives.Text = "Olives";
            this.CHB_Olives.UseVisualStyleBackColor = true;
            this.CHB_Olives.CheckedChanged += new System.EventHandler(this.CHB_Olives_CheckedChanged);
            // 
            // CHB_Onion
            // 
            this.CHB_Onion.AutoSize = true;
            this.CHB_Onion.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Onion.Location = new System.Drawing.Point(204, 25);
            this.CHB_Onion.Name = "CHB_Onion";
            this.CHB_Onion.Size = new System.Drawing.Size(120, 44);
            this.CHB_Onion.TabIndex = 3;
            this.CHB_Onion.Tag = "3";
            this.CHB_Onion.Text = "Onion";
            this.CHB_Onion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CHB_Onion.UseVisualStyleBackColor = true;
            this.CHB_Onion.CheckedChanged += new System.EventHandler(this.CHB_Onion_CheckedChanged);
            // 
            // CHB_Tomatoes
            // 
            this.CHB_Tomatoes.AutoSize = true;
            this.CHB_Tomatoes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Tomatoes.Location = new System.Drawing.Point(6, 123);
            this.CHB_Tomatoes.Name = "CHB_Tomatoes";
            this.CHB_Tomatoes.Size = new System.Drawing.Size(169, 44);
            this.CHB_Tomatoes.TabIndex = 2;
            this.CHB_Tomatoes.Tag = "3";
            this.CHB_Tomatoes.Text = "Tomatoes";
            this.CHB_Tomatoes.UseVisualStyleBackColor = true;
            this.CHB_Tomatoes.CheckedChanged += new System.EventHandler(this.CHB_Tomatoes_CheckedChanged);
            // 
            // CHB_Musgrooms
            // 
            this.CHB_Musgrooms.AutoSize = true;
            this.CHB_Musgrooms.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Musgrooms.Location = new System.Drawing.Point(6, 74);
            this.CHB_Musgrooms.Name = "CHB_Musgrooms";
            this.CHB_Musgrooms.Size = new System.Drawing.Size(200, 44);
            this.CHB_Musgrooms.TabIndex = 1;
            this.CHB_Musgrooms.Tag = "3";
            this.CHB_Musgrooms.Text = "Mushrooms";
            this.CHB_Musgrooms.UseVisualStyleBackColor = true;
            this.CHB_Musgrooms.CheckedChanged += new System.EventHandler(this.CHB_Musgrooms_CheckedChanged);
            // 
            // CHB_ExtraChees
            // 
            this.CHB_ExtraChees.AutoSize = true;
            this.CHB_ExtraChees.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_ExtraChees.Location = new System.Drawing.Point(6, 25);
            this.CHB_ExtraChees.Name = "CHB_ExtraChees";
            this.CHB_ExtraChees.Size = new System.Drawing.Size(210, 44);
            this.CHB_ExtraChees.TabIndex = 0;
            this.CHB_ExtraChees.Tag = "3";
            this.CHB_ExtraChees.Text = "Extra Cheese";
            this.CHB_ExtraChees.UseVisualStyleBackColor = true;
            this.CHB_ExtraChees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.RDB_Takeout);
            this.groupBox5.Controls.Add(this.RDB_EatIn);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.SandyBrown;
            this.groupBox5.Location = new System.Drawing.Point(385, 508);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 105);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Where To Eat 🍽️";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // RDB_Takeout
            // 
            this.RDB_Takeout.AutoSize = true;
            this.RDB_Takeout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_Takeout.ForeColor = System.Drawing.Color.SandyBrown;
            this.RDB_Takeout.Location = new System.Drawing.Point(199, 38);
            this.RDB_Takeout.Name = "RDB_Takeout";
            this.RDB_Takeout.Size = new System.Drawing.Size(108, 29);
            this.RDB_Takeout.TabIndex = 6;
            this.RDB_Takeout.TabStop = true;
            this.RDB_Takeout.Text = "Take Out";
            this.RDB_Takeout.UseVisualStyleBackColor = true;
            // 
            // RDB_EatIn
            // 
            this.RDB_EatIn.AutoSize = true;
            this.RDB_EatIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDB_EatIn.ForeColor = System.Drawing.Color.SandyBrown;
            this.RDB_EatIn.Location = new System.Drawing.Point(26, 38);
            this.RDB_EatIn.Name = "RDB_EatIn";
            this.RDB_EatIn.Size = new System.Drawing.Size(80, 29);
            this.RDB_EatIn.TabIndex = 5;
            this.RDB_EatIn.TabStop = true;
            this.RDB_EatIn.Text = "Eat In";
            this.RDB_EatIn.UseVisualStyleBackColor = true;
            this.RDB_EatIn.CheckedChanged += new System.EventHandler(this.RDB_EatIn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(845, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Price:";
            // 
            // LB_Price
            // 
            this.LB_Price.AutoSize = true;
            this.LB_Price.BackColor = System.Drawing.Color.Transparent;
            this.LB_Price.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Price.ForeColor = System.Drawing.Color.Orange;
            this.LB_Price.Location = new System.Drawing.Point(981, 622);
            this.LB_Price.Name = "LB_Price";
            this.LB_Price.Size = new System.Drawing.Size(112, 56);
            this.LB_Price.TabIndex = 6;
            this.LB_Price.Text = "0LE";
            this.LB_Price.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // BUT_OrderPizza
            // 
            this.BUT_OrderPizza.BackColor = System.Drawing.Color.Violet;
            this.BUT_OrderPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUT_OrderPizza.BackgroundImage")));
            this.BUT_OrderPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUT_OrderPizza.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.BUT_OrderPizza.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_OrderPizza.Location = new System.Drawing.Point(401, 639);
            this.BUT_OrderPizza.Name = "BUT_OrderPizza";
            this.BUT_OrderPizza.Size = new System.Drawing.Size(136, 45);
            this.BUT_OrderPizza.TabIndex = 7;
            this.BUT_OrderPizza.Text = "Order Pizza";
            this.BUT_OrderPizza.UseVisualStyleBackColor = false;
            this.BUT_OrderPizza.Click += new System.EventHandler(this.BUT_OrderPizza_Click);
            // 
            // BUT_ResetForm
            // 
            this.BUT_ResetForm.BackColor = System.Drawing.Color.Transparent;
            this.BUT_ResetForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUT_ResetForm.BackgroundImage")));
            this.BUT_ResetForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUT_ResetForm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_ResetForm.ForeColor = System.Drawing.Color.Black;
            this.BUT_ResetForm.Location = new System.Drawing.Point(584, 639);
            this.BUT_ResetForm.Name = "BUT_ResetForm";
            this.BUT_ResetForm.Size = new System.Drawing.Size(149, 45);
            this.BUT_ResetForm.TabIndex = 8;
            this.BUT_ResetForm.Text = "Reset Form";
            this.BUT_ResetForm.UseVisualStyleBackColor = false;
            this.BUT_ResetForm.Click += new System.EventHandler(this.BUT_ResetForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(352, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 110);
            this.label3.TabIndex = 9;
            this.label3.Text = "Menu 🍕";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Imoge
            // 
            this.Imoge.AutoSize = true;
            this.Imoge.BackColor = System.Drawing.Color.Transparent;
            this.Imoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imoge.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Imoge.Location = new System.Drawing.Point(473, 123);
            this.Imoge.Name = "Imoge";
            this.Imoge.Size = new System.Drawing.Size(154, 108);
            this.Imoge.TabIndex = 10;
            this.Imoge.Text = "🍕";
            this.Imoge.Click += new System.EventHandler(this.Imoge_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(1090, 693);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 23);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "0";
            this.radioButton1.Text = "Size";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 687);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Imoge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BUT_ResetForm);
            this.Controls.Add(this.GrbSize);
            this.Controls.Add(this.BUT_OrderPizza);
            this.Controls.Add(this.LB_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Grb_Topping);
            this.Controls.Add(this.GRB_Curst);
            this.DoubleBuffered = true;
            this.Name = "MainMenu1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu1_Load);
            this.GrbSize.ResumeLayout(false);
            this.GrbSize.PerformLayout();
            this.GRB_Curst.ResumeLayout(false);
            this.GRB_Curst.PerformLayout();
            this.Grb_Topping.ResumeLayout(false);
            this.Grb_Topping.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbSize;
        private System.Windows.Forms.GroupBox GRB_Curst;
        private System.Windows.Forms.RadioButton RD_ThickCurst;
        private System.Windows.Forms.RadioButton RD_ThinCrust;
        private System.Windows.Forms.GroupBox Grb_Topping;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Price;
        private System.Windows.Forms.CheckBox CHB_ExtraChees;
        private System.Windows.Forms.CheckBox CHB_Tomatoes;
        private System.Windows.Forms.CheckBox CHB_Musgrooms;
        private System.Windows.Forms.CheckBox CHB_GreenPeppers;
        private System.Windows.Forms.CheckBox CHB_Olives;
        private System.Windows.Forms.CheckBox CHB_Onion;
        private System.Windows.Forms.RadioButton RDB_Takeout;
        private System.Windows.Forms.RadioButton RDB_EatIn;
        private System.Windows.Forms.Button BUT_OrderPizza;
        private System.Windows.Forms.Button BUT_ResetForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Imoge;
        private System.Windows.Forms.RadioButton RD_Larg;
        private System.Windows.Forms.RadioButton RD_Small;
        private System.Windows.Forms.RadioButton RD_Medium;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

