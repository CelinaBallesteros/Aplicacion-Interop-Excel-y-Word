namespace TestInteropc_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGuardarWord = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnGuardarExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarWord
            // 
            this.btnGuardarWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarWord.BackgroundImage")));
            this.btnGuardarWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarWord.Location = new System.Drawing.Point(21, 107);
            this.btnGuardarWord.Name = "btnGuardarWord";
            this.btnGuardarWord.Size = new System.Drawing.Size(83, 49);
            this.btnGuardarWord.TabIndex = 0;
            this.btnGuardarWord.UseVisualStyleBackColor = false;
            this.btnGuardarWord.Click += new System.EventHandler(this.btnGuardarWord_Click);
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDato.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(41, 56);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(144, 32);
            this.txtDato.TabIndex = 1;
            // 
            // btnGuardarExcel
            // 
            this.btnGuardarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarExcel.BackgroundImage")));
            this.btnGuardarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarExcel.Location = new System.Drawing.Point(122, 106);
            this.btnGuardarExcel.Name = "btnGuardarExcel";
            this.btnGuardarExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGuardarExcel.Size = new System.Drawing.Size(83, 49);
            this.btnGuardarExcel.TabIndex = 2;
            this.btnGuardarExcel.UseVisualStyleBackColor = false;
            this.btnGuardarExcel.Click += new System.EventHandler(this.btnGuardarExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa tu texto :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(221, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarExcel);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnGuardarWord);
            this.Name = "Form1";
            this.Text = "TestInterop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarWord;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnGuardarExcel;
        private System.Windows.Forms.Label label1;
    }
}

