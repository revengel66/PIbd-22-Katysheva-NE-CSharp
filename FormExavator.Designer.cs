
namespace KatyshevaExcavator
{
    partial class FormExavator
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExavator));
            this.pictureBoxEx = new System.Windows.Forms.PictureBox();
            this.buttonCreateExcavator = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateTrackedVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEx
            // 
            this.pictureBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEx.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEx.Name = "pictureBoxEx";
            this.pictureBoxEx.Size = new System.Drawing.Size(882, 453);
            this.pictureBoxEx.TabIndex = 0;
            this.pictureBoxEx.TabStop = false;
            this.pictureBoxEx.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateExcavator
            // 
            this.buttonCreateExcavator.Location = new System.Drawing.Point(256, 12);
            this.buttonCreateExcavator.Name = "buttonCreateExcavator";
            this.buttonCreateExcavator.Size = new System.Drawing.Size(170, 42);
            this.buttonCreateExcavator.TabIndex = 6;
            this.buttonCreateExcavator.Text = "Создать экскаватор";
            this.buttonCreateExcavator.Click += new System.EventHandler(this.buttonCreateExcavator_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(762, 349);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(726, 385);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(798, 385);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(762, 385);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateTrackedVehicle
            // 
            this.buttonCreateTrackedVehicle.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateTrackedVehicle.Name = "buttonCreateTrackedVehicle";
            this.buttonCreateTrackedVehicle.Size = new System.Drawing.Size(226, 42);
            this.buttonCreateTrackedVehicle.TabIndex = 7;
            this.buttonCreateTrackedVehicle.Text = "Создать гусеничную машину";
            this.buttonCreateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateTrackedVehicle.Click += new System.EventHandler(this.buttonCreateTrackedVehicle_Click);
            // 
            // FormExavator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateTrackedVehicle);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateExcavator);
            this.Controls.Add(this.pictureBoxEx);
            this.Name = "FormExavator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экскаватор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEx;
        private System.Windows.Forms.Button buttonCreateExcavator;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateTrackedVehicle;
    }
}

