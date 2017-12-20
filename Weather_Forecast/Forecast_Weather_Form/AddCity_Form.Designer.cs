namespace Forecast_Weather_Form
{
    partial class AddCity_Form
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
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLng = new System.Windows.Forms.Label();
            this.inptCityName = new System.Windows.Forms.TextBox();
            this.inptLat = new System.Windows.Forms.TextBox();
            this.inptLng = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(34, 60);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(84, 17);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "Naziv grada";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(34, 98);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(28, 17);
            this.lblLat.TabIndex = 1;
            this.lblLat.Text = "Lat";
            // 
            // lblLng
            // 
            this.lblLng.AutoSize = true;
            this.lblLng.Location = new System.Drawing.Point(34, 133);
            this.lblLng.Name = "lblLng";
            this.lblLng.Size = new System.Drawing.Size(32, 17);
            this.lblLng.TabIndex = 2;
            this.lblLng.Text = "Lng";
            this.lblLng.Click += new System.EventHandler(this.label2_Click);
            // 
            // inptCityName
            // 
            this.inptCityName.Location = new System.Drawing.Point(158, 60);
            this.inptCityName.Name = "inptCityName";
            this.inptCityName.Size = new System.Drawing.Size(110, 22);
            this.inptCityName.TabIndex = 3;
            // 
            // inptLat
            // 
            this.inptLat.Location = new System.Drawing.Point(158, 98);
            this.inptLat.Name = "inptLat";
            this.inptLat.Size = new System.Drawing.Size(110, 22);
            this.inptLat.TabIndex = 4;
            // 
            // inptLng
            // 
            this.inptLng.Location = new System.Drawing.Point(158, 133);
            this.inptLng.Name = "inptLng";
            this.inptLng.Size = new System.Drawing.Size(110, 22);
            this.inptLng.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Spremi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddCity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 287);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptLng);
            this.Controls.Add(this.inptLat);
            this.Controls.Add(this.inptCityName);
            this.Controls.Add(this.lblLng);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblCityName);
            this.Name = "AddCity_Form";
            this.Text = "AddCity_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLng;
        private System.Windows.Forms.TextBox inptCityName;
        private System.Windows.Forms.TextBox inptLat;
        private System.Windows.Forms.TextBox inptLng;
        private System.Windows.Forms.Button btnAdd;
    }
}