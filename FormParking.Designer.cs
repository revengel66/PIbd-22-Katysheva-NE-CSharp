
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
            this.groupBoxPark = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPark = new System.Windows.Forms.MaskedTextBox();
            this.labelPark = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddPark = new System.Windows.Forms.Button();
            this.buttonDelPark = new System.Windows.Forms.Button();
            this.buttonAddTransport = new System.Windows.Forms.Button();
            this.menuStripTransport = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogTransport = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTransport = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxPark.SuspendLayout();
            this.menuStripTransport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-1, 31);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(973, 530);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxPark
            // 
            this.groupBoxPark.Controls.Add(this.buttonTake);
            this.groupBoxPark.Controls.Add(this.maskedTextBoxPark);
            this.groupBoxPark.Controls.Add(this.labelPark);
            this.groupBoxPark.Location = new System.Drawing.Point(996, 428);
            this.groupBoxPark.Name = "groupBoxPark";
            this.groupBoxPark.Size = new System.Drawing.Size(168, 127);
            this.groupBoxPark.TabIndex = 3;
            this.groupBoxPark.TabStop = false;
            this.groupBoxPark.Text = "Забрать машину";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(11, 80);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(151, 29);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxPark
            // 
            this.maskedTextBoxPark.Location = new System.Drawing.Point(72, 33);
            this.maskedTextBoxPark.Name = "maskedTextBoxPark";
            this.maskedTextBoxPark.Size = new System.Drawing.Size(55, 27);
            this.maskedTextBoxPark.TabIndex = 1;
            // 
            // labelPark
            // 
            this.labelPark.AutoSize = true;
            this.labelPark.Location = new System.Drawing.Point(11, 36);
            this.labelPark.Name = "labelPark";
            this.labelPark.Size = new System.Drawing.Size(55, 20);
            this.labelPark.TabIndex = 0;
            this.labelPark.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 20;
            this.listBoxParkings.Location = new System.Drawing.Point(996, 103);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(168, 104);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(996, 33);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(168, 27);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddPark
            // 
            this.buttonAddPark.Location = new System.Drawing.Point(996, 66);
            this.buttonAddPark.Name = "buttonAddPark";
            this.buttonAddPark.Size = new System.Drawing.Size(168, 29);
            this.buttonAddPark.TabIndex = 6;
            this.buttonAddPark.Text = "Добавить парковку";
            this.buttonAddPark.UseVisualStyleBackColor = true;
            this.buttonAddPark.Click += new System.EventHandler(this.buttonAddPark_Click);
            // 
            // buttonDelPark
            // 
            this.buttonDelPark.Location = new System.Drawing.Point(996, 213);
            this.buttonDelPark.Name = "buttonDelPark";
            this.buttonDelPark.Size = new System.Drawing.Size(168, 33);
            this.buttonDelPark.TabIndex = 7;
            this.buttonDelPark.Text = "Удалить парковку";
            this.buttonDelPark.UseVisualStyleBackColor = true;
            this.buttonDelPark.Click += new System.EventHandler(this.buttonDelPark_Click);
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.Location = new System.Drawing.Point(996, 370);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Size = new System.Drawing.Size(168, 42);
            this.buttonAddTransport.TabIndex = 8;
            this.buttonAddTransport.Text = "Добавить машину";
            this.buttonAddTransport.UseVisualStyleBackColor = true;
            this.buttonAddTransport.Click += new System.EventHandler(this.buttonAddTransport_Click);
            // 
            // menuStripTransport
            // 
            this.menuStripTransport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTransport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripTransport.Location = new System.Drawing.Point(0, 0);
            this.menuStripTransport.Name = "menuStripTransport";
            this.menuStripTransport.Size = new System.Drawing.Size(1185, 28);
            this.menuStripTransport.TabIndex = 9;
            this.menuStripTransport.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialogTransport
            // 
            this.saveFileDialogTransport.Filter = "txt file | *.txt";
            // 
            // openFileDialogTransport
            // 
            this.openFileDialogTransport.FileName = "openFileDialogTransport";
            this.openFileDialogTransport.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 562);
            this.Controls.Add(this.buttonAddTransport);
            this.Controls.Add(this.buttonDelPark);
            this.Controls.Add(this.buttonAddPark);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxPark);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripTransport);
            this.MainMenuStrip = this.menuStripTransport;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxPark.ResumeLayout(false);
            this.groupBoxPark.PerformLayout();
            this.menuStripTransport.ResumeLayout(false);
            this.menuStripTransport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxPark;
        private System.Windows.Forms.Label labelPark;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPark;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddPark;
        private System.Windows.Forms.Button buttonDelPark;
        private System.Windows.Forms.Button buttonAddTransport;
        private System.Windows.Forms.MenuStrip menuStripTransport;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTransport;
        private System.Windows.Forms.OpenFileDialog openFileDialogTransport;
    }
}