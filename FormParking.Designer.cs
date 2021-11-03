
namespace KatyshevaExcavator
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.ParkTracVehButton = new System.Windows.Forms.Button();
            this.ParkExButton = new System.Windows.Forms.Button();
            this.groupBoxPark = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPark = new System.Windows.Forms.MaskedTextBox();
            this.labelPark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxPark.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(973, 561);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // ParkTracVehButton
            // 
            this.ParkTracVehButton.Location = new System.Drawing.Point(991, 12);
            this.ParkTracVehButton.Name = "ParkTracVehButton";
            this.ParkTracVehButton.Size = new System.Drawing.Size(141, 80);
            this.ParkTracVehButton.TabIndex = 1;
            this.ParkTracVehButton.Text = "Припарковать гусеничную машину";
            this.ParkTracVehButton.UseVisualStyleBackColor = true;
            this.ParkTracVehButton.Click += new System.EventHandler(this.ParkTracVehButton_Click);
            // 
            // ParkExButton
            // 
            this.ParkExButton.Location = new System.Drawing.Point(991, 98);
            this.ParkExButton.Name = "ParkExButton";
            this.ParkExButton.Size = new System.Drawing.Size(141, 55);
            this.ParkExButton.TabIndex = 2;
            this.ParkExButton.Text = "Припарковать экскаватор";
            this.ParkExButton.UseVisualStyleBackColor = true;
            this.ParkExButton.Click += new System.EventHandler(this.ParkExButton_Click);
            // 
            // groupBoxPark
            // 
            this.groupBoxPark.Controls.Add(this.buttonTake);
            this.groupBoxPark.Controls.Add(this.maskedTextBoxPark);
            this.groupBoxPark.Controls.Add(this.labelPark);
            this.groupBoxPark.Location = new System.Drawing.Point(991, 159);
            this.groupBoxPark.Name = "groupBoxPark";
            this.groupBoxPark.Size = new System.Drawing.Size(148, 127);
            this.groupBoxPark.TabIndex = 3;
            this.groupBoxPark.TabStop = false;
            this.groupBoxPark.Text = "Забрать машину";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(28, 92);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(94, 29);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxPark
            // 
            this.maskedTextBoxPark.Location = new System.Drawing.Point(67, 46);
            this.maskedTextBoxPark.Name = "maskedTextBoxPark";
            this.maskedTextBoxPark.Size = new System.Drawing.Size(55, 27);
            this.maskedTextBoxPark.TabIndex = 1;
            // 
            // labelPark
            // 
            this.labelPark.AutoSize = true;
            this.labelPark.Location = new System.Drawing.Point(6, 49);
            this.labelPark.Name = "labelPark";
            this.labelPark.Size = new System.Drawing.Size(55, 20);
            this.labelPark.TabIndex = 0;
            this.labelPark.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 562);
            this.Controls.Add(this.groupBoxPark);
            this.Controls.Add(this.ParkExButton);
            this.Controls.Add(this.ParkTracVehButton);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxPark.ResumeLayout(false);
            this.groupBoxPark.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button ParkTracVehButton;
        private System.Windows.Forms.Button ParkExButton;
        private System.Windows.Forms.GroupBox groupBoxPark;
        private System.Windows.Forms.Label labelPark;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPark;
    }
}