namespace WindowsFormsApp5
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLiner = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelViolet = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelShip = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLiner);
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип плавательного средства";
            // 
            // labelLiner
            // 
            this.labelLiner.AllowDrop = true;
            this.labelLiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLiner.Location = new System.Drawing.Point(44, 86);
            this.labelLiner.Name = "labelLiner";
            this.labelLiner.Size = new System.Drawing.Size(52, 25);
            this.labelLiner.TabIndex = 1;
            this.labelLiner.Text = "Лайнер";
            this.labelLiner.Click += new System.EventHandler(this.labelLiner_Click);
            this.labelLiner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLiner_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.AllowDrop = true;
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(41, 36);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(55, 33);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.Click += new System.EventHandler(this.labelShip_Click);
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelViolet);
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Location = new System.Drawing.Point(433, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelViolet
            // 
            this.panelViolet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelViolet.Location = new System.Drawing.Point(145, 71);
            this.panelViolet.Name = "panelViolet";
            this.panelViolet.Size = new System.Drawing.Size(36, 32);
            this.panelViolet.TabIndex = 7;
            this.panelViolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWhite_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(102, 71);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(36, 32);
            this.panelOrange.TabIndex = 6;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWhite_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(60, 71);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(36, 32);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWhite_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(18, 71);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(36, 32);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWhite_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(146, 21);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(36, 32);
            this.panelGreen.TabIndex = 3;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGreen_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(103, 21);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(36, 32);
            this.panelYellow.TabIndex = 2;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelYellow_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(61, 21);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(36, 32);
            this.panelRed.TabIndex = 1;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(19, 21);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(36, 32);
            this.panelWhite.TabIndex = 0;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWhite_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Controls.Add(this.labelBaseColor);
            this.panelShip.Controls.Add(this.pictureBox1);
            this.panelShip.Location = new System.Drawing.Point(164, 24);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(263, 253);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(16, 206);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(244, 34);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(101, 155);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(72, 40);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Цвет";
            this.labelBaseColor.Click += new System.EventHandler(this.labelBaseColor_Click);
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(33, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(36, 171);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 37);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(37, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 37);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 297);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLiner;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelViolet;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}