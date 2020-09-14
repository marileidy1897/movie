namespace movie.PL
{
    partial class frmActor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textGender = new System.Windows.Forms.TextBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textGender);
            this.panel1.Controls.Add(this.imgBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 387);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(61, 321);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 34);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(61, 237);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(348, 22);
            this.textGender.TabIndex = 7;
            // 
            // imgBox
            // 
            this.imgBox.Image = global::movie.Properties.Resources.Untitled;
            this.imgBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox.InitialImage")));
            this.imgBox.Location = new System.Drawing.Point(457, 56);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(177, 173);
            this.imgBox.TabIndex = 6;
            this.imgBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(61, 166);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(346, 22);
            this.txtDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(61, 92);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(348, 22);
            this.textName.TabIndex = 0;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 388);
            this.Controls.Add(this.panel1);
            this.Name = "frmActor";
            this.Text = "Movie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textGender;
    }
}