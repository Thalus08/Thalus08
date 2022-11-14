namespace WindowsFormsApp2
{
    partial class Form1
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
            this.showleader_Button = new System.Windows.Forms.Button();
            this.showleader_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showpic_Button = new System.Windows.Forms.Button();
            this.clearpic_Button = new System.Windows.Forms.Button();
            this.backgroundpic_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mathgame_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showleader_Button
            // 
            this.showleader_Button.Location = new System.Drawing.Point(36, 48);
            this.showleader_Button.Name = "showleader_Button";
            this.showleader_Button.Size = new System.Drawing.Size(75, 23);
            this.showleader_Button.TabIndex = 0;
            this.showleader_Button.Text = "Leader";
            this.showleader_Button.UseVisualStyleBackColor = true;
            this.showleader_Button.Click += new System.EventHandler(this.showleader_Button_Click);
            // 
            // showleader_Label
            // 
            this.showleader_Label.AutoSize = true;
            this.showleader_Label.Location = new System.Drawing.Point(53, 74);
            this.showleader_Label.Name = "showleader_Label";
            this.showleader_Label.Size = new System.Drawing.Size(53, 13);
            this.showleader_Label.TabIndex = 1;
            this.showleader_Label.Text = "Unknown";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(465, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 476);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showpic_Button);
            this.flowLayoutPanel1.Controls.Add(this.clearpic_Button);
            this.flowLayoutPanel1.Controls.Add(this.backgroundpic_Button);
            this.flowLayoutPanel1.Controls.Add(this.close_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(164, 383);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 90);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showpic_Button
            // 
            this.showpic_Button.AutoSize = true;
            this.showpic_Button.Location = new System.Drawing.Point(389, 3);
            this.showpic_Button.Name = "showpic_Button";
            this.showpic_Button.Size = new System.Drawing.Size(88, 23);
            this.showpic_Button.TabIndex = 0;
            this.showpic_Button.Text = "Show a picture";
            this.showpic_Button.UseVisualStyleBackColor = true;
            this.showpic_Button.Click += new System.EventHandler(this.showpic_Button_Click);
            // 
            // clearpic_Button
            // 
            this.clearpic_Button.AutoSize = true;
            this.clearpic_Button.Location = new System.Drawing.Point(289, 3);
            this.clearpic_Button.Name = "clearpic_Button";
            this.clearpic_Button.Size = new System.Drawing.Size(94, 23);
            this.clearpic_Button.TabIndex = 1;
            this.clearpic_Button.Text = "Clear the picture";
            this.clearpic_Button.UseVisualStyleBackColor = true;
            this.clearpic_Button.Click += new System.EventHandler(this.clearpic_Button_Click);
            // 
            // backgroundpic_Button
            // 
            this.backgroundpic_Button.AutoSize = true;
            this.backgroundpic_Button.Location = new System.Drawing.Point(146, 3);
            this.backgroundpic_Button.Name = "backgroundpic_Button";
            this.backgroundpic_Button.Size = new System.Drawing.Size(137, 23);
            this.backgroundpic_Button.TabIndex = 2;
            this.backgroundpic_Button.Text = "Set the background color";
            this.backgroundpic_Button.UseVisualStyleBackColor = true;
            this.backgroundpic_Button.Click += new System.EventHandler(this.backgroundpic_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.AutoSize = true;
            this.close_Button.Location = new System.Drawing.Point(65, 3);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 3;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mathgame_Button
            // 
            this.mathgame_Button.BackColor = System.Drawing.Color.Transparent;
            this.mathgame_Button.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Raiden_Shogun_41;
            this.mathgame_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mathgame_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mathgame_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathgame_Button.ForeColor = System.Drawing.Color.White;
            this.mathgame_Button.Location = new System.Drawing.Point(171, 221);
            this.mathgame_Button.Name = "mathgame_Button";
            this.mathgame_Button.Size = new System.Drawing.Size(116, 114);
            this.mathgame_Button.TabIndex = 3;
            this.mathgame_Button.Text = "Math Game";
            this.mathgame_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.mathgame_Button.UseVisualStyleBackColor = false;
            this.mathgame_Button.Click += new System.EventHandler(this.mathgame_Button_Click);
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 589);
            this.Controls.Add(this.mathgame_Button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.showleader_Label);
            this.Controls.Add(this.showleader_Button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nahidder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showleader_Button;
        private System.Windows.Forms.Label showleader_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showpic_Button;
        private System.Windows.Forms.Button clearpic_Button;
        private System.Windows.Forms.Button backgroundpic_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button mathgame_Button;
    }
}

