
namespace KatyshevaExcavator
{
    partial class FormTrackVehConfig
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxСounterweight = new System.Windows.Forms.CheckBox();
            this.checkBoxHandle = new System.Windows.Forms.CheckBox();
            this.checkBoxBucket = new System.Windows.Forms.CheckBox();
            this.checkBoxArrow = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelExcavator = new System.Windows.Forms.Label();
            this.labelTrackVeh = new System.Windows.Forms.Label();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelDarkGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelDarkBlue = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonСancel = new System.Windows.Forms.Button();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxСounterweight);
            this.groupBoxOptions.Controls.Add(this.checkBoxHandle);
            this.groupBoxOptions.Controls.Add(this.checkBoxBucket);
            this.groupBoxOptions.Controls.Add(this.checkBoxArrow);
            this.groupBoxOptions.Controls.Add(this.numericUpDownWeight);
            this.groupBoxOptions.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxOptions.Controls.Add(this.labelWeight);
            this.groupBoxOptions.Controls.Add(this.labelMaxSpeed);
            this.groupBoxOptions.Location = new System.Drawing.Point(19, 181);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOptions.Size = new System.Drawing.Size(175, 247);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Параметры:";
            // 
            // checkBoxСounterweight
            // 
            this.checkBoxСounterweight.AutoSize = true;
            this.checkBoxСounterweight.Location = new System.Drawing.Point(6, 196);
            this.checkBoxСounterweight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxСounterweight.Name = "checkBoxСounterweight";
            this.checkBoxСounterweight.Size = new System.Drawing.Size(108, 21);
            this.checkBoxСounterweight.TabIndex = 7;
            this.checkBoxСounterweight.Text = "Противовес";
            this.checkBoxСounterweight.UseVisualStyleBackColor = true;
            // 
            // checkBoxHandle
            // 
            this.checkBoxHandle.AutoSize = true;
            this.checkBoxHandle.Location = new System.Drawing.Point(6, 146);
            this.checkBoxHandle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxHandle.Name = "checkBoxHandle";
            this.checkBoxHandle.Size = new System.Drawing.Size(83, 21);
            this.checkBoxHandle.TabIndex = 5;
            this.checkBoxHandle.Text = "Рукоять";
            this.checkBoxHandle.UseVisualStyleBackColor = true;
            // 
            // checkBoxBucket
            // 
            this.checkBoxBucket.AutoSize = true;
            this.checkBoxBucket.Location = new System.Drawing.Point(6, 121);
            this.checkBoxBucket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBucket.Name = "checkBoxBucket";
            this.checkBoxBucket.Size = new System.Drawing.Size(65, 21);
            this.checkBoxBucket.TabIndex = 4;
            this.checkBoxBucket.Text = "Ковш";
            this.checkBoxBucket.UseVisualStyleBackColor = true;
            // 
            // checkBoxArrow
            // 
            this.checkBoxArrow.AutoSize = true;
            this.checkBoxArrow.Location = new System.Drawing.Point(6, 171);
            this.checkBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxArrow.Name = "checkBoxArrow";
            this.checkBoxArrow.Size = new System.Drawing.Size(78, 21);
            this.checkBoxArrow.TabIndex = 6;
            this.checkBoxArrow.Text = "Стрела";
            this.checkBoxArrow.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(83, 71);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(83, 37);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.Location = new System.Drawing.Point(6, 69);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(83, 40);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес машины:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 26);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(100, 43);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(16, 13);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(514, 365);
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelExcavator);
            this.groupBoxType.Controls.Add(this.labelTrackVeh);
            this.groupBoxType.Location = new System.Drawing.Point(19, 10);
            this.groupBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxType.Size = new System.Drawing.Size(175, 137);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип машины";
            // 
            // labelExcavator
            // 
            this.labelExcavator.AllowDrop = true;
            this.labelExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExcavator.Location = new System.Drawing.Point(20, 78);
            this.labelExcavator.Name = "labelExcavator";
            this.labelExcavator.Size = new System.Drawing.Size(140, 26);
            this.labelExcavator.TabIndex = 1;
            this.labelExcavator.Text = "Экскаватор";
            this.labelExcavator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExcavator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExcavator_MouseDown);
            // 
            // labelTrackVeh
            // 
            this.labelTrackVeh.AllowDrop = true;
            this.labelTrackVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrackVeh.Location = new System.Drawing.Point(20, 29);
            this.labelTrackVeh.Name = "labelTrackVeh";
            this.labelTrackVeh.Size = new System.Drawing.Size(140, 38);
            this.labelTrackVeh.TabIndex = 0;
            this.labelTrackVeh.Text = "Гусеничная машина";
            this.labelTrackVeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrackVeh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrackVeh_MouseDown);
            // 
            // panelPreview
            // 
            this.panelPreview.AllowDrop = true;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.pictureBoxPreview);
            this.panelPreview.Location = new System.Drawing.Point(215, 5);
            this.panelPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(547, 391);
            this.panelPreview.TabIndex = 3;
            this.panelPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPreview_DragDrop);
            this.panelPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPreview_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelDarkGreen);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelDarkBlue);
            this.groupBoxColor.Controls.Add(this.panelPink);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(215, 400);
            this.groupBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxColor.Size = new System.Drawing.Size(346, 114);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(241, 67);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(89, 40);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(240, 19);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(90, 42);
            this.labelMainColor.TabIndex = 8;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(185, 67);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 40);
            this.panelGreen.TabIndex = 7;
            // 
            // panelDarkGreen
            // 
            this.panelDarkGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.panelDarkGreen.Location = new System.Drawing.Point(184, 21);
            this.panelDarkGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDarkGreen.Name = "panelDarkGreen";
            this.panelDarkGreen.Size = new System.Drawing.Size(50, 40);
            this.panelDarkGreen.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(17, 67);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 40);
            this.panelYellow.TabIndex = 5;
            // 
            // panelDarkBlue
            // 
            this.panelDarkBlue.BackColor = System.Drawing.Color.Navy;
            this.panelDarkBlue.Location = new System.Drawing.Point(129, 21);
            this.panelDarkBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDarkBlue.Name = "panelDarkBlue";
            this.panelDarkBlue.Size = new System.Drawing.Size(50, 40);
            this.panelDarkBlue.TabIndex = 4;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.HotPink;
            this.panelPink.Location = new System.Drawing.Point(73, 67);
            this.panelPink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(50, 40);
            this.panelPink.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBlue.Location = new System.Drawing.Point(129, 67);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 40);
            this.panelBlue.TabIndex = 3;
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.MediumPurple;
            this.panelPurple.Location = new System.Drawing.Point(73, 21);
            this.panelPurple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(50, 40);
            this.panelPurple.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Crimson;
            this.panelRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRed.Location = new System.Drawing.Point(17, 21);
            this.panelRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 40);
            this.panelRed.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(567, 410);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 33);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonСancel
            // 
            this.buttonСancel.Location = new System.Drawing.Point(567, 471);
            this.buttonСancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonСancel.Name = "buttonСancel";
            this.buttonСancel.Size = new System.Drawing.Size(94, 32);
            this.buttonСancel.TabIndex = 6;
            this.buttonСancel.Text = "Отмена";
            this.buttonСancel.UseVisualStyleBackColor = true;
            // 
            // FormTrackVehConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 570);
            this.Controls.Add(this.buttonСancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxOptions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrackVehConfig";
            this.Text = "Выбор машины";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxBucket;
        private System.Windows.Forms.CheckBox checkBoxHandle;
        private System.Windows.Forms.CheckBox checkBoxArrow;
        private System.Windows.Forms.CheckBox checkBoxСounterweight;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelExcavator;
        private System.Windows.Forms.Label labelTrackVeh;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelDarkGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelDarkBlue;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonСancel;
    }
}